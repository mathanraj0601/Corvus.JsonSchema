//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Patch.SpecGenerator;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct ScenarioWithResult
{
    private static readonly ImmutableDictionary<JsonPropertyName, PropertyValidator<ScenarioWithResult>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    /// <summary>
    /// JSON property name for <see cref = "Expected"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ExpectedUtf8JsonPropertyName = new byte[]{101, 120, 112, 101, 99, 116, 101, 100};
    /// <summary>
    /// JSON property name for <see cref = "Expected"/>.
    /// </summary>
    public const string ExpectedJsonPropertyName = "expected";
    /// <summary>
    /// JSON property name for <see cref = "Doc"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DocUtf8JsonPropertyName = new byte[]{100, 111, 99};
    /// <summary>
    /// JSON property name for <see cref = "Doc"/>.
    /// </summary>
    public const string DocJsonPropertyName = "doc";
    /// <summary>
    /// JSON property name for <see cref = "Patch"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> PatchUtf8JsonPropertyName = new byte[]{112, 97, 116, 99, 104};
    /// <summary>
    /// JSON property name for <see cref = "Patch"/>.
    /// </summary>
    public const string PatchJsonPropertyName = "patch";
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> CommentUtf8JsonPropertyName = new byte[]{99, 111, 109, 109, 101, 110, 116};
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public const string CommentJsonPropertyName = "comment";
    /// <summary>
    /// JSON property name for <see cref = "Disabled"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DisabledUtf8JsonPropertyName = new byte[]{100, 105, 115, 97, 98, 108, 101, 100};
    /// <summary>
    /// JSON property name for <see cref = "Disabled"/>.
    /// </summary>
    public const string DisabledJsonPropertyName = "disabled";
    /// <summary>
    /// Gets Expected.
    /// </summary>
    public Corvus.Json.JsonAny Expected
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ExpectedUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonAny(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ExpectedJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonAny>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Doc.
    /// </summary>
    public Corvus.Json.JsonAny Doc
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DocUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonAny(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DocJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonAny>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Patch.
    /// </summary>
    public Corvus.Json.JsonAny Patch
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PatchUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonAny(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PatchJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonAny>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Comment.
    /// </summary>
    public Corvus.Json.JsonString Comment
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CommentUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CommentJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Disabled.
    /// </summary>
    public Corvus.Json.JsonNotAny Disabled
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DisabledUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonNotAny(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DisabledJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonNotAny>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "ScenarioWithResult"/>.
    /// </summary>
    public static ScenarioWithResult Create(Corvus.Json.JsonAny expected, Corvus.Json.JsonAny doc, Corvus.Json.JsonAny patch, Corvus.Json.JsonString? comment = null, Corvus.Json.JsonNotAny? disabled = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(ExpectedJsonPropertyName, expected.AsAny);
        builder.Add(DocJsonPropertyName, doc.AsAny);
        builder.Add(PatchJsonPropertyName, patch.AsAny);
        if (comment is Corvus.Json.JsonString comment__)
        {
            builder.Add(CommentJsonPropertyName, comment__.AsAny);
        }

        if (disabled is Corvus.Json.JsonNotAny disabled__)
        {
            builder.Add(DisabledJsonPropertyName, disabled__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets expected.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ScenarioWithResult WithExpected(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(ExpectedJsonPropertyName, value);
    }

    /// <summary>
    /// Sets doc.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ScenarioWithResult WithDoc(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(DocJsonPropertyName, value);
    }

    /// <summary>
    /// Sets patch.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ScenarioWithResult WithPatch(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(PatchJsonPropertyName, value);
    }

    /// <summary>
    /// Sets comment.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ScenarioWithResult WithComment(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(CommentJsonPropertyName, value);
    }

    /// <summary>
    /// Sets disabled.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public ScenarioWithResult WithDisabled(in Corvus.Json.JsonNotAny value)
    {
        return this.SetProperty(DisabledJsonPropertyName, value);
    }

    private static ImmutableDictionary<JsonPropertyName, PropertyValidator<ScenarioWithResult>> CreateLocalPropertyValidators()
    {
        ImmutableDictionary<JsonPropertyName, PropertyValidator<ScenarioWithResult>>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, PropertyValidator<ScenarioWithResult>>();
        builder.Add(ExpectedJsonPropertyName, __CorvusValidateExpected);
        return builder.ToImmutable();
    }

    private static ValidationContext __CorvusValidateExpected(in ScenarioWithResult that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonAny property = that.Expected;
        return property.Validate(validationContext, level);
    }
}