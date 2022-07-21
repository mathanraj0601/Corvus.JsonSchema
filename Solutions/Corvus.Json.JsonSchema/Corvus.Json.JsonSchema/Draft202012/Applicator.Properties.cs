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
public readonly partial struct Applicator
{
    private static readonly ImmutableDictionary<JsonPropertyName, PropertyValidator<Applicator>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    /// <summary>
    /// JSON property name for <see cref = "PrefixItems"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> PrefixItemsUtf8JsonPropertyName = new byte[]{112, 114, 101, 102, 105, 120, 73, 116, 101, 109, 115};
    /// <summary>
    /// JSON property name for <see cref = "PrefixItems"/>.
    /// </summary>
    public const string PrefixItemsJsonPropertyName = "prefixItems";
    /// <summary>
    /// JSON property name for <see cref = "Items"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ItemsUtf8JsonPropertyName = new byte[]{105, 116, 101, 109, 115};
    /// <summary>
    /// JSON property name for <see cref = "Items"/>.
    /// </summary>
    public const string ItemsJsonPropertyName = "items";
    /// <summary>
    /// JSON property name for <see cref = "Contains"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ContainsUtf8JsonPropertyName = new byte[]{99, 111, 110, 116, 97, 105, 110, 115};
    /// <summary>
    /// JSON property name for <see cref = "Contains"/>.
    /// </summary>
    public const string ContainsJsonPropertyName = "contains";
    /// <summary>
    /// JSON property name for <see cref = "AdditionalProperties"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> AdditionalPropertiesUtf8JsonPropertyName = new byte[]{97, 100, 100, 105, 116, 105, 111, 110, 97, 108, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115};
    /// <summary>
    /// JSON property name for <see cref = "AdditionalProperties"/>.
    /// </summary>
    public const string AdditionalPropertiesJsonPropertyName = "additionalProperties";
    /// <summary>
    /// JSON property name for <see cref = "Properties"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> PropertiesUtf8JsonPropertyName = new byte[]{112, 114, 111, 112, 101, 114, 116, 105, 101, 115};
    /// <summary>
    /// JSON property name for <see cref = "Properties"/>.
    /// </summary>
    public const string PropertiesJsonPropertyName = "properties";
    /// <summary>
    /// JSON property name for <see cref = "PatternProperties"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> PatternPropertiesUtf8JsonPropertyName = new byte[]{112, 97, 116, 116, 101, 114, 110, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115};
    /// <summary>
    /// JSON property name for <see cref = "PatternProperties"/>.
    /// </summary>
    public const string PatternPropertiesJsonPropertyName = "patternProperties";
    /// <summary>
    /// JSON property name for <see cref = "DependentSchemas"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DependentSchemasUtf8JsonPropertyName = new byte[]{100, 101, 112, 101, 110, 100, 101, 110, 116, 83, 99, 104, 101, 109, 97, 115};
    /// <summary>
    /// JSON property name for <see cref = "DependentSchemas"/>.
    /// </summary>
    public const string DependentSchemasJsonPropertyName = "dependentSchemas";
    /// <summary>
    /// JSON property name for <see cref = "PropertyNames"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> PropertyNamesUtf8JsonPropertyName = new byte[]{112, 114, 111, 112, 101, 114, 116, 121, 78, 97, 109, 101, 115};
    /// <summary>
    /// JSON property name for <see cref = "PropertyNames"/>.
    /// </summary>
    public const string PropertyNamesJsonPropertyName = "propertyNames";
    /// <summary>
    /// JSON property name for <see cref = "If"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> IfUtf8JsonPropertyName = new byte[]{105, 102};
    /// <summary>
    /// JSON property name for <see cref = "If"/>.
    /// </summary>
    public const string IfJsonPropertyName = "if";
    /// <summary>
    /// JSON property name for <see cref = "Then"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ThenUtf8JsonPropertyName = new byte[]{116, 104, 101, 110};
    /// <summary>
    /// JSON property name for <see cref = "Then"/>.
    /// </summary>
    public const string ThenJsonPropertyName = "then";
    /// <summary>
    /// JSON property name for <see cref = "Else"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> ElseUtf8JsonPropertyName = new byte[]{101, 108, 115, 101};
    /// <summary>
    /// JSON property name for <see cref = "Else"/>.
    /// </summary>
    public const string ElseJsonPropertyName = "else";
    /// <summary>
    /// JSON property name for <see cref = "AllOf"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> AllOfUtf8JsonPropertyName = new byte[]{97, 108, 108, 79, 102};
    /// <summary>
    /// JSON property name for <see cref = "AllOf"/>.
    /// </summary>
    public const string AllOfJsonPropertyName = "allOf";
    /// <summary>
    /// JSON property name for <see cref = "AnyOf"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> AnyOfUtf8JsonPropertyName = new byte[]{97, 110, 121, 79, 102};
    /// <summary>
    /// JSON property name for <see cref = "AnyOf"/>.
    /// </summary>
    public const string AnyOfJsonPropertyName = "anyOf";
    /// <summary>
    /// JSON property name for <see cref = "OneOf"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> OneOfUtf8JsonPropertyName = new byte[]{111, 110, 101, 79, 102};
    /// <summary>
    /// JSON property name for <see cref = "OneOf"/>.
    /// </summary>
    public const string OneOfJsonPropertyName = "oneOf";
    /// <summary>
    /// JSON property name for <see cref = "Not"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> NotUtf8JsonPropertyName = new byte[]{110, 111, 116};
    /// <summary>
    /// JSON property name for <see cref = "Not"/>.
    /// </summary>
    public const string NotJsonPropertyName = "not";
    /// <summary>
    /// Gets PrefixItems.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray PrefixItems
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PrefixItemsUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PrefixItemsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Items.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema Items
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ItemsUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ItemsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Contains.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema Contains
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ContainsUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ContainsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AdditionalProperties.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema AdditionalProperties
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AdditionalPropertiesUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AdditionalPropertiesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Properties.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue Properties
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PropertiesUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PropertiesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PatternProperties.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue PatternProperties
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PatternPropertiesUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PatternPropertiesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets DependentSchemas.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue DependentSchemas
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DependentSchemasUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DependentSchemasJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets PropertyNames.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema PropertyNames
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(PropertyNamesUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(PropertyNamesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets If.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema If
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(IfUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(IfJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Then.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema Then
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ThenUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ThenJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Else.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema Else
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(ElseUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(ElseJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AllOf.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray AllOf
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AllOfUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AllOfJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets AnyOf.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray AnyOf
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(AnyOfUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(AnyOfJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets OneOf.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray OneOf
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(OneOfUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(OneOfJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Not.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema Not
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(NotUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(NotJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Applicator"/>.
    /// </summary>
    public static Applicator Create(Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray? prefixItems = null, Corvus.Json.JsonSchema.Draft202012.Schema? items = null, Corvus.Json.JsonSchema.Draft202012.Schema? contains = null, Corvus.Json.JsonSchema.Draft202012.Schema? additionalProperties = null, Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue? properties = null, Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue? patternProperties = null, Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue? dependentSchemas = null, Corvus.Json.JsonSchema.Draft202012.Schema? propertyNames = null, Corvus.Json.JsonSchema.Draft202012.Schema? @if = null, Corvus.Json.JsonSchema.Draft202012.Schema? then = null, Corvus.Json.JsonSchema.Draft202012.Schema? @else = null, Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray? allOf = null, Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray? anyOf = null, Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray? oneOf = null, Corvus.Json.JsonSchema.Draft202012.Schema? not = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (prefixItems is Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray prefixItems__)
        {
            builder.Add(PrefixItemsJsonPropertyName, prefixItems__.AsAny);
        }

        if (items is Corvus.Json.JsonSchema.Draft202012.Schema items__)
        {
            builder.Add(ItemsJsonPropertyName, items__.AsAny);
        }

        if (contains is Corvus.Json.JsonSchema.Draft202012.Schema contains__)
        {
            builder.Add(ContainsJsonPropertyName, contains__.AsAny);
        }

        if (additionalProperties is Corvus.Json.JsonSchema.Draft202012.Schema additionalProperties__)
        {
            builder.Add(AdditionalPropertiesJsonPropertyName, additionalProperties__.AsAny);
        }

        if (properties is Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue properties__)
        {
            builder.Add(PropertiesJsonPropertyName, properties__.AsAny);
        }

        if (patternProperties is Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue patternProperties__)
        {
            builder.Add(PatternPropertiesJsonPropertyName, patternProperties__.AsAny);
        }

        if (dependentSchemas is Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue dependentSchemas__)
        {
            builder.Add(DependentSchemasJsonPropertyName, dependentSchemas__.AsAny);
        }

        if (propertyNames is Corvus.Json.JsonSchema.Draft202012.Schema propertyNames__)
        {
            builder.Add(PropertyNamesJsonPropertyName, propertyNames__.AsAny);
        }

        if (@if is Corvus.Json.JsonSchema.Draft202012.Schema @if__)
        {
            builder.Add(IfJsonPropertyName, @if__.AsAny);
        }

        if (then is Corvus.Json.JsonSchema.Draft202012.Schema then__)
        {
            builder.Add(ThenJsonPropertyName, then__.AsAny);
        }

        if (@else is Corvus.Json.JsonSchema.Draft202012.Schema @else__)
        {
            builder.Add(ElseJsonPropertyName, @else__.AsAny);
        }

        if (allOf is Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray allOf__)
        {
            builder.Add(AllOfJsonPropertyName, allOf__.AsAny);
        }

        if (anyOf is Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray anyOf__)
        {
            builder.Add(AnyOfJsonPropertyName, anyOf__.AsAny);
        }

        if (oneOf is Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray oneOf__)
        {
            builder.Add(OneOfJsonPropertyName, oneOf__.AsAny);
        }

        if (not is Corvus.Json.JsonSchema.Draft202012.Schema not__)
        {
            builder.Add(NotJsonPropertyName, not__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets prefixItems.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithPrefixItems(in Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray value)
    {
        return this.SetProperty(PrefixItemsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets items.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithItems(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(ItemsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets contains.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithContains(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(ContainsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets additionalProperties.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithAdditionalProperties(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(AdditionalPropertiesJsonPropertyName, value);
    }

    /// <summary>
    /// Sets properties.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithProperties(in Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue value)
    {
        return this.SetProperty(PropertiesJsonPropertyName, value);
    }

    /// <summary>
    /// Sets patternProperties.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithPatternProperties(in Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue value)
    {
        return this.SetProperty(PatternPropertiesJsonPropertyName, value);
    }

    /// <summary>
    /// Sets dependentSchemas.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithDependentSchemas(in Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue value)
    {
        return this.SetProperty(DependentSchemasJsonPropertyName, value);
    }

    /// <summary>
    /// Sets propertyNames.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithPropertyNames(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(PropertyNamesJsonPropertyName, value);
    }

    /// <summary>
    /// Sets if.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithIf(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(IfJsonPropertyName, value);
    }

    /// <summary>
    /// Sets then.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithThen(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(ThenJsonPropertyName, value);
    }

    /// <summary>
    /// Sets else.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithElse(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(ElseJsonPropertyName, value);
    }

    /// <summary>
    /// Sets allOf.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithAllOf(in Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray value)
    {
        return this.SetProperty(AllOfJsonPropertyName, value);
    }

    /// <summary>
    /// Sets anyOf.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithAnyOf(in Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray value)
    {
        return this.SetProperty(AnyOfJsonPropertyName, value);
    }

    /// <summary>
    /// Sets oneOf.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithOneOf(in Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray value)
    {
        return this.SetProperty(OneOfJsonPropertyName, value);
    }

    /// <summary>
    /// Sets not.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Applicator WithNot(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(NotJsonPropertyName, value);
    }

    private static ImmutableDictionary<JsonPropertyName, PropertyValidator<Applicator>> CreateLocalPropertyValidators()
    {
        ImmutableDictionary<JsonPropertyName, PropertyValidator<Applicator>>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, PropertyValidator<Applicator>>();
        builder.Add(PrefixItemsJsonPropertyName, __CorvusValidatePrefixItems);
        builder.Add(ItemsJsonPropertyName, __CorvusValidateItems);
        builder.Add(ContainsJsonPropertyName, __CorvusValidateContains);
        builder.Add(AdditionalPropertiesJsonPropertyName, __CorvusValidateAdditionalProperties);
        builder.Add(PropertiesJsonPropertyName, __CorvusValidateProperties);
        builder.Add(PatternPropertiesJsonPropertyName, __CorvusValidatePatternProperties);
        builder.Add(DependentSchemasJsonPropertyName, __CorvusValidateDependentSchemas);
        builder.Add(PropertyNamesJsonPropertyName, __CorvusValidatePropertyNames);
        builder.Add(IfJsonPropertyName, __CorvusValidateIf);
        builder.Add(ThenJsonPropertyName, __CorvusValidateThen);
        builder.Add(ElseJsonPropertyName, __CorvusValidateElse);
        builder.Add(AllOfJsonPropertyName, __CorvusValidateAllOf);
        builder.Add(AnyOfJsonPropertyName, __CorvusValidateAnyOf);
        builder.Add(OneOfJsonPropertyName, __CorvusValidateOneOf);
        builder.Add(NotJsonPropertyName, __CorvusValidateNot);
        return builder.ToImmutable();
    }

    private static ValidationContext __CorvusValidatePrefixItems(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray property = that.PrefixItems;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateItems(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.Items;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateContains(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.Contains;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAdditionalProperties(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.AdditionalProperties;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateProperties(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.PropertiesValue property = that.Properties;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePatternProperties(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.PatternPropertiesValue property = that.PatternProperties;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDependentSchemas(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.DependentSchemasValue property = that.DependentSchemas;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidatePropertyNames(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.PropertyNames;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateIf(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.If;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateThen(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.Then;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateElse(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.Else;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAllOf(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray property = that.AllOf;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateAnyOf(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray property = that.AnyOf;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateOneOf(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Applicator.SchemaArray property = that.OneOf;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateNot(in Applicator that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.Not;
        return property.Validate(validationContext, level);
    }
}