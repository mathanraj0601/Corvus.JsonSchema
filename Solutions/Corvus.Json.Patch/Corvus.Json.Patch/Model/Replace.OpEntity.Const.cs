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

namespace Corvus.Json.Patch.Model;
public readonly partial struct Replace
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct OpEntity
    {
        private static readonly OpEntity __CorvusConstValue = JsonAny.Parse("\"replace\"");
        /// <summary>
        /// Initializes a new instance of the <see cref = "OpEntity"/> struct.
        /// </summary>
        public OpEntity()
        {
            this.jsonElementBacking = __CorvusConstValue.jsonElementBacking;
            this.stringBacking = __CorvusConstValue.stringBacking;
            this.backing = __CorvusConstValue.backing;
        }

        /// <summary>
        /// Gets the constant value for this instance
        /// </summary>
        public static OpEntity ConstInstance => __CorvusConstValue;
    }
}