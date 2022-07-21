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
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace JsonSchemaSample.Api;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct PersonName
{
    private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        if (valueKind != JsonValueKind.Object)
        {
            return result;
        }

        int propertyCount = 0;
        bool foundFamilyName = false;
        foreach (JsonObjectProperty property in this.EnumerateObject())
        {
            JsonPropertyName propertyName = property.Name;
            if (__CorvusLocalProperties.TryGetValue(propertyName, out PropertyValidator<PersonName>? propertyValidator))
            {
                result = result.WithLocalProperty(propertyCount);
                var propertyResult = propertyValidator(this, result.CreateChildContext(), level);
                result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if (FamilyNameJsonPropertyName.Equals(propertyName))
                {
                    foundFamilyName = true;
                }
            }

            propertyCount++;
        }

        if (!foundFamilyName)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"familyName\" not present.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
            }
            else
            {
                return result.WithResult(isValid: false);
            }
        }

        return result;
    }
}