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

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Core
{
    private static readonly ImmutableDictionary<JsonPropertyName, PropertyValidator<Core>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    /// <summary>
    /// JSON property name for <see cref = "Id"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> IdUtf8JsonPropertyName = new byte[]{36, 105, 100};
    /// <summary>
    /// JSON property name for <see cref = "Id"/>.
    /// </summary>
    public const string IdJsonPropertyName = "$id";
    /// <summary>
    /// JSON property name for <see cref = "Schema"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> SchemaUtf8JsonPropertyName = new byte[]{36, 115, 99, 104, 101, 109, 97};
    /// <summary>
    /// JSON property name for <see cref = "Schema"/>.
    /// </summary>
    public const string SchemaJsonPropertyName = "$schema";
    /// <summary>
    /// JSON property name for <see cref = "Ref"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> RefUtf8JsonPropertyName = new byte[]{36, 114, 101, 102};
    /// <summary>
    /// JSON property name for <see cref = "Ref"/>.
    /// </summary>
    public const string RefJsonPropertyName = "$ref";
    /// <summary>
    /// JSON property name for <see cref = "Anchor"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> AnchorUtf8JsonPropertyName = new byte[]{36, 97, 110, 99, 104, 111, 114};
    /// <summary>
    /// JSON property name for <see cref = "Anchor"/>.
    /// </summary>
    public const string AnchorJsonPropertyName = "$anchor";
    /// <summary>
    /// JSON property name for <see cref = "DynamicRef"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DynamicRefUtf8JsonPropertyName = new byte[]{36, 100, 121, 110, 97, 109, 105, 99, 82, 101, 102};
    /// <summary>
    /// JSON property name for <see cref = "DynamicRef"/>.
    /// </summary>
    public const string DynamicRefJsonPropertyName = "$dynamicRef";
    /// <summary>
    /// JSON property name for <see cref = "DynamicAnchor"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DynamicAnchorUtf8JsonPropertyName = new byte[]{36, 100, 121, 110, 97, 109, 105, 99, 65, 110, 99, 104, 111, 114};
    /// <summary>
    /// JSON property name for <see cref = "DynamicAnchor"/>.
    /// </summary>
    public const string DynamicAnchorJsonPropertyName = "$dynamicAnchor";
    /// <summary>
    /// JSON property name for <see cref = "Vocabulary"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> VocabularyUtf8JsonPropertyName = new byte[]{36, 118, 111, 99, 97, 98, 117, 108, 97, 114, 121};
    /// <summary>
    /// JSON property name for <see cref = "Vocabulary"/>.
    /// </summary>
    public const string VocabularyJsonPropertyName = "$vocabulary";
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> CommentUtf8JsonPropertyName = new byte[]{36, 99, 111, 109, 109, 101, 110, 116};
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public const string CommentJsonPropertyName = "$comment";
    /// <summary>
    /// JSON property name for <see cref = "Defs"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DefsUtf8JsonPropertyName = new byte[]{36, 100, 101, 102, 115};
    /// <summary>
    /// JSON property name for <see cref = "Defs"/>.
    /// </summary>
    public const string DefsJsonPropertyName = "$defs";
    /// <summary>
    /// Gets Id.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Core.IdEntity Id
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(IdUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Core.IdEntity(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(IdJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Core.IdEntity>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Schema.
    /// </summary>
    public Corvus.Json.JsonUri Schema
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(SchemaUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonUri(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(SchemaJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonUri>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Ref.
    /// </summary>
    public Corvus.Json.JsonUriReference Ref
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(RefUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonUriReference(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(RefJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonUriReference>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Anchor.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue Anchor
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AnchorUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AnchorJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets DynamicRef.
    /// </summary>
    public Corvus.Json.JsonUriReference DynamicRef
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DynamicRefUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonUriReference(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DynamicRefJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonUriReference>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets DynamicAnchor.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue DynamicAnchor
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DynamicAnchorUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DynamicAnchorJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Vocabulary.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue Vocabulary
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(VocabularyUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(VocabularyJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue>();
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
    /// Gets Defs.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Core.DefsValue Defs
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DefsUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Core.DefsValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DefsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Core.DefsValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Core"/>.
    /// </summary>
    public static Core Create(Corvus.Json.JsonSchema.Draft202012.Core.IdEntity? id = null, Corvus.Json.JsonUri? schema = null, Corvus.Json.JsonUriReference? @ref = null, Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue? anchor = null, Corvus.Json.JsonUriReference? dynamicRef = null, Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue? dynamicAnchor = null, Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue? vocabulary = null, Corvus.Json.JsonString? comment = null, Corvus.Json.JsonSchema.Draft202012.Core.DefsValue? defs = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (id is Corvus.Json.JsonSchema.Draft202012.Core.IdEntity id__)
        {
            builder.Add(IdJsonPropertyName, id__.AsAny);
        }

        if (schema is Corvus.Json.JsonUri schema__)
        {
            builder.Add(SchemaJsonPropertyName, schema__.AsAny);
        }

        if (@ref is Corvus.Json.JsonUriReference @ref__)
        {
            builder.Add(RefJsonPropertyName, @ref__.AsAny);
        }

        if (anchor is Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue anchor__)
        {
            builder.Add(AnchorJsonPropertyName, anchor__.AsAny);
        }

        if (dynamicRef is Corvus.Json.JsonUriReference dynamicRef__)
        {
            builder.Add(DynamicRefJsonPropertyName, dynamicRef__.AsAny);
        }

        if (dynamicAnchor is Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue dynamicAnchor__)
        {
            builder.Add(DynamicAnchorJsonPropertyName, dynamicAnchor__.AsAny);
        }

        if (vocabulary is Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue vocabulary__)
        {
            builder.Add(VocabularyJsonPropertyName, vocabulary__.AsAny);
        }

        if (comment is Corvus.Json.JsonString comment__)
        {
            builder.Add(CommentJsonPropertyName, comment__.AsAny);
        }

        if (defs is Corvus.Json.JsonSchema.Draft202012.Core.DefsValue defs__)
        {
            builder.Add(DefsJsonPropertyName, defs__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets $id.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithId(in Corvus.Json.JsonSchema.Draft202012.Core.IdEntity value)
    {
        return this.SetProperty(IdJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $schema.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithSchema(in Corvus.Json.JsonUri value)
    {
        return this.SetProperty(SchemaJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $ref.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithRef(in Corvus.Json.JsonUriReference value)
    {
        return this.SetProperty(RefJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $anchor.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithAnchor(in Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue value)
    {
        return this.SetProperty(AnchorJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $dynamicRef.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithDynamicRef(in Corvus.Json.JsonUriReference value)
    {
        return this.SetProperty(DynamicRefJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $dynamicAnchor.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithDynamicAnchor(in Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue value)
    {
        return this.SetProperty(DynamicAnchorJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $vocabulary.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithVocabulary(in Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue value)
    {
        return this.SetProperty(VocabularyJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $comment.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithComment(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(CommentJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $defs.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithDefs(in Corvus.Json.JsonSchema.Draft202012.Core.DefsValue value)
    {
        return this.SetProperty(DefsJsonPropertyName, value);
    }

    private static ImmutableDictionary<JsonPropertyName, PropertyValidator<Core>> CreateLocalPropertyValidators()
    {
        ImmutableDictionary<JsonPropertyName, PropertyValidator<Core>>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, PropertyValidator<Core>>();
        builder.Add(IdJsonPropertyName, __CorvusValidateId);
        builder.Add(SchemaJsonPropertyName, __CorvusValidateSchema);
        builder.Add(RefJsonPropertyName, __CorvusValidateRef);
        builder.Add(AnchorJsonPropertyName, __CorvusValidateAnchor);
        builder.Add(DynamicRefJsonPropertyName, __CorvusValidateDynamicRef);
        builder.Add(DynamicAnchorJsonPropertyName, __CorvusValidateDynamicAnchor);
        builder.Add(VocabularyJsonPropertyName, __CorvusValidateVocabulary);
        builder.Add(CommentJsonPropertyName, __CorvusValidateComment);
        builder.Add(DefsJsonPropertyName, __CorvusValidateDefs);
        return builder.ToImmutable();
    }

    private static ValidationContext __CorvusValidateId(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Core.IdEntity property = that.Id;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateSchema(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonUri property = that.Schema;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateRef(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonUriReference property = that.Ref;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAnchor(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue property = that.Anchor;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDynamicRef(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonUriReference property = that.DynamicRef;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDynamicAnchor(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Core.AnchorStringValue property = that.DynamicAnchor;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateVocabulary(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Core.VocabularyValue property = that.Vocabulary;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateComment(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonString property = that.Comment;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDefs(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Core.DefsValue property = that.Defs;
        return property.Validate(validationContext, level);
    }
}