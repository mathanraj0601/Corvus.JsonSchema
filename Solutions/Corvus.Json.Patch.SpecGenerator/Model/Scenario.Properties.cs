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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Patch.SpecGenerator;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Scenario
{
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public static ReadOnlySpan<byte> CommentUtf8JsonPropertyName => "comment"u8;

    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public const string CommentJsonPropertyName = "comment";
    /// <summary>
    /// JSON property name for <see cref = "Doc"/>.
    /// </summary>
    public static ReadOnlySpan<byte> DocUtf8JsonPropertyName => "doc"u8;

    /// <summary>
    /// JSON property name for <see cref = "Doc"/>.
    /// </summary>
    public const string DocJsonPropertyName = "doc";
    /// <summary>
    /// JSON property name for <see cref = "Patch"/>.
    /// </summary>
    public static ReadOnlySpan<byte> PatchUtf8JsonPropertyName => "patch"u8;

    /// <summary>
    /// JSON property name for <see cref = "Patch"/>.
    /// </summary>
    public const string PatchJsonPropertyName = "patch";
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

                if (this.jsonElementBacking.TryGetProperty(CommentUtf8JsonPropertyName, out JsonElement result))
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

                if (this.jsonElementBacking.TryGetProperty(DocUtf8JsonPropertyName, out JsonElement result))
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

                if (this.jsonElementBacking.TryGetProperty(PatchUtf8JsonPropertyName, out JsonElement result))
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
    /// Creates an instance of a <see cref = "Scenario"/>.
    /// </summary>
    public static Scenario Create(Corvus.Json.JsonAny doc, Corvus.Json.JsonAny patch, Corvus.Json.JsonString? comment = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(DocJsonPropertyName, doc.AsAny);
        builder.Add(PatchJsonPropertyName, patch.AsAny);
        if (comment is Corvus.Json.JsonString comment__)
        {
            builder.Add(CommentJsonPropertyName, comment__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets comment.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Scenario WithComment(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(CommentJsonPropertyName, value);
    }

    /// <summary>
    /// Sets doc.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Scenario WithDoc(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(DocJsonPropertyName, value);
    }

    /// <summary>
    /// Sets patch.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Scenario WithPatch(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(PatchJsonPropertyName, value);
    }

    /// <summary>
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name = "property">The property for which to get the validator.</param>
    /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
    {
        if (hasJsonElementBacking)
        {
        }
        else
        {
        }

        propertyValidator = null;
        return false;
    }
}