//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct NonNegativeIntegerDefault0Entity
    {
        private ValidationContext ValidateRef(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            ValidationContext refResult = this.As<Corvus.Json.JsonSchema.Draft201909.Validation.NonNegativeIntegerValue>().Validate(validationContext.CreateChildContext(), level);
            if (!refResult.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = validationContext.MergeResults(false, level, refResult);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = validationContext.MergeResults(false, level, refResult);
                }
                else
                {
                    result = validationContext.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, refResult);
                }

                result = result.MergeChildContext(refResult, false);
            }

            return result;
        }
    }
}