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
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Patch.SpecGenerator;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct DisabledScenario
{
    private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        if (valueKind != JsonValueKind.Object)
        {
            return result;
        }

        int propertyCount = 0;
        bool foundDisabled = false;
        foreach (JsonObjectProperty property in this.EnumerateObject())
        {
            if (__TryGetCorvusLocalPropertiesValidator(property, this.HasJsonElementBacking, out ObjectPropertyValidator? propertyValidator))
            {
                result = result.WithLocalProperty(propertyCount);
                var propertyResult = propertyValidator(property, result.CreateChildContext(), level);
                result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                if ((this.HasJsonElementBacking && property.NameEquals(DisabledUtf8JsonPropertyName.Span)) || (!this.HasJsonElementBacking && property.NameEquals(DisabledJsonPropertyName)))
                {
                    foundDisabled = true;
                }
            }

            propertyCount++;
        }

        if (!foundDisabled)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.WithResult(isValid: false, $"6.5.3. required - required property \"disabled\" not present.");
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