//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Text.Json;
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct JsonAnyArray
    {
        private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Array)
            {
                return result;
            }

            int arrayLength = 0;
            var arrayEnumerator = this.EnumerateArray();
            while (arrayEnumerator.MoveNext())
            {
                result = arrayEnumerator.Current.As<Corvus.Json.JsonAny>().Validate(result, level);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                result = result.WithLocalItemIndex(arrayLength);
                arrayLength++;
            }

            return result;
        }
    }
}