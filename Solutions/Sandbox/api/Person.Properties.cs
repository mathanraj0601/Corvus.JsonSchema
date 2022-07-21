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

namespace JsonSchemaSample.Api;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Person
{
    private static readonly ImmutableDictionary<JsonPropertyName, PropertyValidator<Person>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    /// <summary>
    /// JSON property name for <see cref = "Name"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> NameUtf8JsonPropertyName = new byte[]{110, 97, 109, 101};
    /// <summary>
    /// JSON property name for <see cref = "Name"/>.
    /// </summary>
    public const string NameJsonPropertyName = "name";
    /// <summary>
    /// JSON property name for <see cref = "DateOfBirth"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> DateOfBirthUtf8JsonPropertyName = new byte[]{100, 97, 116, 101, 79, 102, 66, 105, 114, 116, 104};
    /// <summary>
    /// JSON property name for <see cref = "DateOfBirth"/>.
    /// </summary>
    public const string DateOfBirthJsonPropertyName = "dateOfBirth";
    /// <summary>
    /// Gets Name.
    /// </summary>
    public JsonSchemaSample.Api.PersonName Name
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(NameUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new JsonSchemaSample.Api.PersonName(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(NameJsonPropertyName, out JsonAny result))
                {
                    return result.As<JsonSchemaSample.Api.PersonName>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets DateOfBirth.
    /// </summary>
    public Corvus.Json.JsonDate DateOfBirth
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(DateOfBirthUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonDate(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(DateOfBirthJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonDate>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Person"/>.
    /// </summary>
    public static Person Create(JsonSchemaSample.Api.PersonName name, Corvus.Json.JsonDate? dateOfBirth = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(NameJsonPropertyName, name.AsAny);
        if (dateOfBirth is Corvus.Json.JsonDate dateOfBirth__)
        {
            builder.Add(DateOfBirthJsonPropertyName, dateOfBirth__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets name.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Person WithName(in JsonSchemaSample.Api.PersonName value)
    {
        return this.SetProperty(NameJsonPropertyName, value);
    }

    /// <summary>
    /// Sets dateOfBirth.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Person WithDateOfBirth(in Corvus.Json.JsonDate value)
    {
        return this.SetProperty(DateOfBirthJsonPropertyName, value);
    }

    private static ImmutableDictionary<JsonPropertyName, PropertyValidator<Person>> CreateLocalPropertyValidators()
    {
        ImmutableDictionary<JsonPropertyName, PropertyValidator<Person>>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, PropertyValidator<Person>>();
        builder.Add(NameJsonPropertyName, __CorvusValidateName);
        builder.Add(DateOfBirthJsonPropertyName, __CorvusValidateDateOfBirth);
        return builder.ToImmutable();
    }

    private static ValidationContext __CorvusValidateName(in Person that, in ValidationContext validationContext, ValidationLevel level)
    {
        JsonSchemaSample.Api.PersonName property = that.Name;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateDateOfBirth(in Person that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonDate property = that.DateOfBirth;
        return property.Validate(validationContext, level);
    }
}