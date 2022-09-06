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
/// A type generated from a JsonSchema() specification.
/// </summary>
public readonly partial struct NotDisabled
{
    /// <summary>
    /// JSON property name for <see cref = "Disabled"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DisabledUtf8JsonPropertyName = new byte[]{100, 105, 115, 97, 98, 108, 101, 100};
    /// <summary>
    /// JSON property name for <see cref = "Disabled"/>.
    /// </summary>
    public const string DisabledJsonPropertyName = "disabled";
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
    /// Tries to get the validator for the given property.
    /// </summary>
    /// <param name = "property">The property for which to get the validator.</param>
    /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
    /// <param name = "propertyValidator">The validator for the property, if provided by this Schema().</param>
    /// <returns><c>True</c> if the validator was found.</returns>
    public bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
    {
        if (hasJsonElementBacking)
        {
            if (property.NameEquals(DisabledUtf8JsonPropertyName.Span))
            {
                propertyValidator = __CorvusValidateDisabled;
                return true;
            }
        }
        else
        {
            if (property.NameEquals(DisabledJsonPropertyName))
            {
                propertyValidator = __CorvusValidateDisabled;
                return true;
            }
        }

        propertyValidator = null;
        return false;
    }

    /// <summary>
    /// Creates an instance of a <see cref = "NotDisabled"/>.
    /// </summary>
    public static NotDisabled Create(Corvus.Json.JsonNotAny? disabled = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (disabled is Corvus.Json.JsonNotAny disabled__)
        {
            builder.Add(DisabledJsonPropertyName, disabled__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets disabled.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public NotDisabled WithDisabled(in Corvus.Json.JsonNotAny value)
    {
        return this.SetProperty(DisabledJsonPropertyName, value);
    }

    private static ValidationContext __CorvusValidateDisabled(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
    {
        return property.ValueAs<Corvus.Json.JsonNotAny>().Validate(validationContext, level);
    }
}