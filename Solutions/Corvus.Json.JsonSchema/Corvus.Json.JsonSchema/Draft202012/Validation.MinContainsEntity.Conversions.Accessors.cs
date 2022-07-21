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

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct MinContainsEntity
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue"/>.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue AsNonNegativeIntegerValue
        {
            get
            {
                return (Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue"/>.
        /// </summary>
        public bool IsNonNegativeIntegerValue
        {
            get
            {
                return ((Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsNonNegativeIntegerValue(out Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue result)
        {
            result = (Corvus.Json.JsonSchema.Draft202012.Validation.NonNegativeIntegerValue)this;
            return result.IsValid();
        }
    }
}