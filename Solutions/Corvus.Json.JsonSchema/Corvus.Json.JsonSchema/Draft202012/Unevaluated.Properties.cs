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
public readonly partial struct Unevaluated
{
    private static readonly ImmutableDictionary<JsonPropertyName, PropertyValidator<Unevaluated>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedItems"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> UnevaluatedItemsUtf8JsonPropertyName = new byte[]{117, 110, 101, 118, 97, 108, 117, 97, 116, 101, 100, 73, 116, 101, 109, 115};
    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedItems"/>.
    /// </summary>
    public const string UnevaluatedItemsJsonPropertyName = "unevaluatedItems";
    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedProperties"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> UnevaluatedPropertiesUtf8JsonPropertyName = new byte[]{117, 110, 101, 118, 97, 108, 117, 97, 116, 101, 100, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115};
    /// <summary>
    /// JSON property name for <see cref = "UnevaluatedProperties"/>.
    /// </summary>
    public const string UnevaluatedPropertiesJsonPropertyName = "unevaluatedProperties";
    /// <summary>
    /// Gets UnevaluatedItems.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema UnevaluatedItems
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(UnevaluatedItemsUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(UnevaluatedItemsJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets UnevaluatedProperties.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft202012.Schema UnevaluatedProperties
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(UnevaluatedPropertiesUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft202012.Schema(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(UnevaluatedPropertiesJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft202012.Schema>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Unevaluated"/>.
    /// </summary>
    public static Unevaluated Create(Corvus.Json.JsonSchema.Draft202012.Schema? unevaluatedItems = null, Corvus.Json.JsonSchema.Draft202012.Schema? unevaluatedProperties = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (unevaluatedItems is Corvus.Json.JsonSchema.Draft202012.Schema unevaluatedItems__)
        {
            builder.Add(UnevaluatedItemsJsonPropertyName, unevaluatedItems__.AsAny);
        }

        if (unevaluatedProperties is Corvus.Json.JsonSchema.Draft202012.Schema unevaluatedProperties__)
        {
            builder.Add(UnevaluatedPropertiesJsonPropertyName, unevaluatedProperties__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets unevaluatedItems.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Unevaluated WithUnevaluatedItems(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(UnevaluatedItemsJsonPropertyName, value);
    }

    /// <summary>
    /// Sets unevaluatedProperties.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Unevaluated WithUnevaluatedProperties(in Corvus.Json.JsonSchema.Draft202012.Schema value)
    {
        return this.SetProperty(UnevaluatedPropertiesJsonPropertyName, value);
    }

    private static ImmutableDictionary<JsonPropertyName, PropertyValidator<Unevaluated>> CreateLocalPropertyValidators()
    {
        ImmutableDictionary<JsonPropertyName, PropertyValidator<Unevaluated>>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, PropertyValidator<Unevaluated>>();
        builder.Add(UnevaluatedItemsJsonPropertyName, __CorvusValidateUnevaluatedItems);
        builder.Add(UnevaluatedPropertiesJsonPropertyName, __CorvusValidateUnevaluatedProperties);
        return builder.ToImmutable();
    }

    private static ValidationContext __CorvusValidateUnevaluatedItems(in Unevaluated that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.UnevaluatedItems;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateUnevaluatedProperties(in Unevaluated that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft202012.Schema property = that.UnevaluatedProperties;
        return property.Validate(validationContext, level);
    }
}