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

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct MetaData
{
    /// <summary>
    /// JSON property name for <see cref = "Title"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> TitleUtf8JsonPropertyName = new byte[]{116, 105, 116, 108, 101};
    /// <summary>
    /// JSON property name for <see cref = "Title"/>.
    /// </summary>
    public const string TitleJsonPropertyName = "title";
    /// <summary>
    /// JSON property name for <see cref = "Description"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DescriptionUtf8JsonPropertyName = new byte[]{100, 101, 115, 99, 114, 105, 112, 116, 105, 111, 110};
    /// <summary>
    /// JSON property name for <see cref = "Description"/>.
    /// </summary>
    public const string DescriptionJsonPropertyName = "description";
    /// <summary>
    /// JSON property name for <see cref = "Default"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DefaultUtf8JsonPropertyName = new byte[]{100, 101, 102, 97, 117, 108, 116};
    /// <summary>
    /// JSON property name for <see cref = "Default"/>.
    /// </summary>
    public const string DefaultJsonPropertyName = "default";
    /// <summary>
    /// JSON property name for <see cref = "Deprecated"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DeprecatedUtf8JsonPropertyName = new byte[]{100, 101, 112, 114, 101, 99, 97, 116, 101, 100};
    /// <summary>
    /// JSON property name for <see cref = "Deprecated"/>.
    /// </summary>
    public const string DeprecatedJsonPropertyName = "deprecated";
    /// <summary>
    /// JSON property name for <see cref = "ReadOnly"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ReadOnlyUtf8JsonPropertyName = new byte[]{114, 101, 97, 100, 79, 110, 108, 121};
    /// <summary>
    /// JSON property name for <see cref = "ReadOnly"/>.
    /// </summary>
    public const string ReadOnlyJsonPropertyName = "readOnly";
    /// <summary>
    /// JSON property name for <see cref = "WriteOnly"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> WriteOnlyUtf8JsonPropertyName = new byte[]{119, 114, 105, 116, 101, 79, 110, 108, 121};
    /// <summary>
    /// JSON property name for <see cref = "WriteOnly"/>.
    /// </summary>
    public const string WriteOnlyJsonPropertyName = "writeOnly";
    /// <summary>
    /// JSON property name for <see cref = "Examples"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ExamplesUtf8JsonPropertyName = new byte[]{101, 120, 97, 109, 112, 108, 101, 115};
    /// <summary>
    /// JSON property name for <see cref = "Examples"/>.
    /// </summary>
    public const string ExamplesJsonPropertyName = "examples";
    /// <summary>
    /// Gets Title.
    /// </summary>
    public Corvus.Json.JsonString Title
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(TitleUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(TitleJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Description.
    /// </summary>
    public Corvus.Json.JsonString Description
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DescriptionUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DescriptionJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Default.
    /// </summary>
    public Corvus.Json.JsonAny Default
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DefaultUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonAny(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DefaultJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonAny>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Deprecated.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue Deprecated
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DeprecatedUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DeprecatedJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets ReadOnly.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue ReadOnly
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ReadOnlyUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ReadOnlyJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets WriteOnly.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue WriteOnly
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(WriteOnlyUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(WriteOnlyJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Examples.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray Examples
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ExamplesUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ExamplesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name = "property">The property for which to get the validator.</param>
    /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    public bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
    {
        if (hasJsonElementBacking)
        {
            if (property.NameEquals(TitleUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateTitle;
                return true;
            }
            else if (property.NameEquals(DescriptionUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateDescription;
                return true;
            }
            else if (property.NameEquals(DefaultUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateDefault;
                return true;
            }
            else if (property.NameEquals(DeprecatedUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateDeprecated;
                return true;
            }
            else if (property.NameEquals(ReadOnlyUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateReadOnly;
                return true;
            }
            else if (property.NameEquals(WriteOnlyUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateWriteOnly;
                return true;
            }
            else if (property.NameEquals(ExamplesUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateExamples;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(TitleJsonPropertyName))
            {
                propertyValidator = __CorvusValidateTitle;
                return true;
            }
            else if (property.NameEquals(DescriptionJsonPropertyName))
            {
                propertyValidator = __CorvusValidateDescription;
                return true;
            }
            else if (property.NameEquals(DefaultJsonPropertyName))
            {
                propertyValidator = __CorvusValidateDefault;
                return true;
            }
            else if (property.NameEquals(DeprecatedJsonPropertyName))
            {
                propertyValidator = __CorvusValidateDeprecated;
                return true;
            }
            else if (property.NameEquals(ReadOnlyJsonPropertyName))
            {
                propertyValidator = __CorvusValidateReadOnly;
                return true;
            }
            else if (property.NameEquals(WriteOnlyJsonPropertyName))
            {
                propertyValidator = __CorvusValidateWriteOnly;
                return true;
            }
            else if (property.NameEquals(ExamplesJsonPropertyName))
            {
                propertyValidator = __CorvusValidateExamples;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }

    /// <summary>
    /// Creates an instance of a <see cref = "MetaData"/>.
    /// </summary>
    public static MetaData Create(Corvus.Json.JsonString? title = null, Corvus.Json.JsonString? description = null, Corvus.Json.JsonAny? @default = null, Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue? deprecated = null, Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue? readOnly = null, Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue? writeOnly = null, Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray? examples = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (title is Corvus.Json.JsonString title__)
        {
            builder.Add(TitleJsonPropertyName, title__.AsAny);
        }

        if (description is Corvus.Json.JsonString description__)
        {
            builder.Add(DescriptionJsonPropertyName, description__.AsAny);
        }

        if (@default is Corvus.Json.JsonAny @default__)
        {
            builder.Add(DefaultJsonPropertyName, @default__.AsAny);
        }

        if (deprecated is Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue deprecated__)
        {
            builder.Add(DeprecatedJsonPropertyName, deprecated__.AsAny);
        }

        if (readOnly is Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue readOnly__)
        {
            builder.Add(ReadOnlyJsonPropertyName, readOnly__.AsAny);
        }

        if (writeOnly is Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue writeOnly__)
        {
            builder.Add(WriteOnlyJsonPropertyName, writeOnly__.AsAny);
        }

        if (examples is Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray examples__)
        {
            builder.Add(ExamplesJsonPropertyName, examples__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets title.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithTitle(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(TitleJsonPropertyName, value);
    }

    /// <summary>
    /// Sets description.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithDescription(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(DescriptionJsonPropertyName, value);
    }

    /// <summary>
    /// Sets default.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithDefault(in Corvus.Json.JsonAny value)
    {
        return this.SetProperty(DefaultJsonPropertyName, value);
    }

    /// <summary>
    /// Sets deprecated.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithDeprecated(in Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue value)
    {
        return this.SetProperty(DeprecatedJsonPropertyName, value);
    }

    /// <summary>
    /// Sets readOnly.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithReadOnly(in Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue value)
    {
        return this.SetProperty(ReadOnlyJsonPropertyName, value);
    }

    /// <summary>
    /// Sets writeOnly.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithWriteOnly(in Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue value)
    {
        return this.SetProperty(WriteOnlyJsonPropertyName, value);
    }

    /// <summary>
    /// Sets examples.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public MetaData WithExamples(in Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray value)
    {
        return this.SetProperty(ExamplesJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateTitle(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDescription(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonString>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDefault(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonAny>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDeprecated(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.DeprecatedValue>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateReadOnly(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.ReadOnlyValue>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateWriteOnly(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.WriteOnlyValue>().Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateExamples(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonSchema.Draft202012.MetaData.JsonAnyArray>().Validate(validationContext, level);
    }
}