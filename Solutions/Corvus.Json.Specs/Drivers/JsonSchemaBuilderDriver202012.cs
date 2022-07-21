﻿// <copyright file="JsonSchemaBuilderDriver202012.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Buffers;
using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Extensions;
using Corvus.Json;
using Corvus.Json.CodeGeneration;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyModel;

namespace Drivers;

/// <summary>
/// A driver for specs for the <see cref="JsonSchemaBuilder"/>.
/// </summary>
public class JsonSchemaBuilderDriver202012 : IJsonSchemaBuilderDriver
{
    private const string GlobalUsings = @"
// <auto-generated/>

global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;";

    private const string RequiresPreviewFeatures = @"
[assembly: System.Runtime.Versioning.RequiresPreviewFeatures]";

    private readonly IConfiguration configuration;
    private readonly JsonSchemaBuilder builder;
    private readonly IDocumentResolver documentResolver = new FileSystemDocumentResolver();
    private TestAssemblyLoadContext? assemblyLoadContext = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSchemaBuilderDriver202012"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <param name="builder">The <see cref="JsonSchemaBuilder"/> instance to drive.</param>
    public JsonSchemaBuilderDriver202012(IConfiguration configuration, JsonSchemaBuilder builder)
    {
        this.configuration = configuration;
        this.builder = builder;
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        if (this.assemblyLoadContext is not null)
        {
            this.documentResolver.Dispose();
            this.assemblyLoadContext!.Unload();
            this.assemblyLoadContext = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.SuppressFinalize(this);
        }
    }

    /// <summary>
    /// Get the <see cref="JsonElement"/> at the given reference location.
    /// </summary>
    /// <param name="filename">The name of the file containing the element.</param>
    /// <param name="referenceFragment">The local reference to the element in the file.</param>
    /// <returns>The element, found in the specified document.</returns>
    public Task<JsonElement?> GetElement(string filename, string referenceFragment)
    {
        string baseDirectory = this.configuration["jsonSchemaBuilder202012DriverSettings:testBaseDirectory"];
        string path = Path.Combine(baseDirectory, filename);
        return this.documentResolver.TryResolve(new JsonReference(path, referenceFragment));
    }

    /// <summary>
    /// Generates a type for the given root schema element.
    /// </summary>
    /// <param name="writeBenchmarks">If <c>true</c>, write benchmark files.</param>
    /// <param name="index">The index of the scenario example.</param>
    /// <param name="filename">The filename containing the schema.</param>
    /// <param name="schemaPath">The path to the schema in the file.</param>
    /// <param name="dataPath">The path to the data in the file.</param>
    /// <param name="featureName">The feature name for the type.</param>
    /// <param name="scenarioName">The scenario name for the type.</param>
    /// <param name="valid">Whether the scenario is expected to be valid.</param>
    /// <returns>The fully qualified type name of the entity we have generated.</returns>
    public async Task<Type> GenerateTypeFor(bool writeBenchmarks, int index, string filename, string schemaPath, string dataPath, string featureName, string scenarioName, bool valid)
    {
        string baseDirectory = this.configuration["jsonSchemaBuilder202012DriverSettings:testBaseDirectory"];
        string path = Path.Combine(baseDirectory, filename) + schemaPath;

        path = await this.builder.RebaseReferenceAsRootDocument(path).ConfigureAwait(false);

        (string RootType, ImmutableDictionary<string, TypeAndCode> GeneratedTypes) generatedTypes = await this.builder.BuildTypesFor(path, $"{featureName}Feature.{scenarioName}").ConfigureAwait(false);

        bool isCorvusType = generatedTypes.RootType.StartsWith("Corvus.");

        IEnumerable<SyntaxTree> syntaxTrees = ParseSyntaxTrees(generatedTypes.GeneratedTypes);

        // We are happy with the defaults (debug etc.)
        var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
        IEnumerable<MetadataReference> references = BuildMetadataReferences();
        var compilation = CSharpCompilation.Create($"Driver.GeneratedTypes_{Guid.NewGuid()}", syntaxTrees, references, options);

        using var outputStream = new MemoryStream();
        EmitResult result = compilation.Emit(outputStream);

        if (!result.Success)
        {
            throw new Exception("Unable to compile generated code\r\n" + BuildCompilationErrors(result));
        }

        outputStream.Flush();
        outputStream.Position = 0;

        Assembly generatedAssembly = this.assemblyLoadContext!.LoadFromStream(outputStream);

        if (isCorvusType)
        {
            return AssemblyLoadContext.Default.Assemblies.Single(a => a.GetName().Name == "Corvus.Json.ExtendedTypes").ExportedTypes.Single(t => t.FullName == generatedTypes.RootType);
        }

        return generatedAssembly.ExportedTypes.Single(t => t.FullName == generatedTypes.RootType);
    }

    /// <summary>
    /// Create an instance of the given <see cref="IJsonValue"/> type from
    /// the json data provided.
    /// </summary>
    /// <param name="type">The type (which must be a <see cref="IJsonValue"/> and have a constructor with a single <see cref="JsonElement"/> parameter.</param>
    /// <param name="data">The JSON data from which to initialize the value.</param>
    /// <returns>An instance of a <see cref="IJsonValue"/> initialized from the data.</returns>
    public IJsonValue CreateInstance(Type type, JsonElement data)
    {
        ConstructorInfo? constructor = type.GetConstructors().SingleOrDefault(c => c.GetParameters().Length == 1 && c.GetParameters()[0].ParameterType.Name.StartsWith("JsonElement"));
        if (constructor is null)
        {
            throw new InvalidOperationException($"Unable to find the public JsonElement constructor on type '{type.FullName}'");
        }

        return CastTo<IJsonValue>.From(constructor.Invoke(new object[] { data }));
    }

    /// <summary>
    /// Create an instance of the given <see cref="IJsonValue"/> type from
    /// the json data provided.
    /// </summary>
    /// <param name="type">The type (which must be a <see cref="IJsonValue"/> and have a constructor with a single <see cref="JsonElement"/> parameter.</param>
    /// <param name="data">The JSON data from which to initialize the value.</param>
    /// <returns>An instance of a <see cref="IJsonValue"/> initialized from the data.</returns>
    public IJsonValue CreateInstance(Type type, string data)
    {
        using var document = JsonDocument.Parse(data);
        return this.CreateInstance(type, document.RootElement.Clone());
    }

    private static string BuildCompilationErrors(EmitResult result)
    {
        var builder = new StringBuilder();
        foreach (Diagnostic diagnostic in result.Diagnostics)
        {
            builder.AppendLine(diagnostic.ToString());
        }

        return builder.ToString();
    }

    private static IEnumerable<MetadataReference> BuildMetadataReferences()
    {
        return from l in DependencyContext.Default.CompileLibraries
               from r in l.ResolveReferencePaths()
               select MetadataReference.CreateFromFile(r);
    }

    private static IEnumerable<SyntaxTree> ParseSyntaxTrees(ImmutableDictionary<string, TypeAndCode> generatedTypes)
    {
        CSharpParseOptions parseOptions = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.Preview);
        yield return CSharpSyntaxTree.ParseText(GlobalUsings, path: "GlobalUsings.cs", options: parseOptions);
        yield return CSharpSyntaxTree.ParseText(RequiresPreviewFeatures, path: "RequiresPreviewFeatures.cs", options: parseOptions);

        foreach (KeyValuePair<string, TypeAndCode> type in generatedTypes)
        {
            foreach (CodeAndFilename codeAndFilename in type.Value.Code)
            {
                yield return CSharpSyntaxTree.ParseText(codeAndFilename.Code, path: codeAndFilename.Filename, options: parseOptions);
            }
        }
    }

    private class TestAssemblyLoadContext : AssemblyLoadContext
    {
        public TestAssemblyLoadContext()
            : base($"TestAssemblyLoadContext_{Guid.NewGuid():N}", isCollectible: true)
        {
        }
    }
}