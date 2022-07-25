//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Runtime.CompilerServices;
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct JsonStringArray
    {
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JsonStringArray Remove(in JsonAny item1)
        {
            return new(this.GetImmutableListWithout(item1));
        }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JsonStringArray Remove<TItem1>(in TItem1 item1)
            where TItem1 : struct, IJsonValue<TItem1>
        {
            return this.Remove(item1.AsAny);
        }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JsonStringArray RemoveAt(int index)
        {
            return new(this.GetImmutableListWithoutRange(index, 1));
        }

        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public JsonStringArray RemoveRange(int index, int count)
        {
            return new(this.GetImmutableListWithoutRange(index, count));
        }
    }
}