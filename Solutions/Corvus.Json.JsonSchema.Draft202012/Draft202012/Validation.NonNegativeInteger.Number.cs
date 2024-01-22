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
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct NonNegativeInteger : IJsonNumber<NonNegativeInteger>, IAdditionOperators<NonNegativeInteger, NonNegativeInteger, NonNegativeInteger>, ISubtractionOperators<NonNegativeInteger, NonNegativeInteger, NonNegativeInteger>, IMultiplyOperators<NonNegativeInteger, NonNegativeInteger, NonNegativeInteger>, IDivisionOperators<NonNegativeInteger, NonNegativeInteger, NonNegativeInteger>, IIncrementOperators<NonNegativeInteger>, IDecrementOperators<NonNegativeInteger>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "NonNegativeInteger"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public NonNegativeInteger(in BinaryJsonNumber value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Number;
            this.numberBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NonNegativeInteger"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to initialize the number.</param>
        public NonNegativeInteger(long value) : this(new BinaryJsonNumber(value))
        {
        }

        /// <summary>
        /// Conversion from JsonNumber.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NonNegativeInteger(JsonNumber value)
        {
            if (value.HasDotnetBacking && value.ValueKind == JsonValueKind.Number)
            {
                return new(value.AsBinaryJsonNumber);
            }

            return new(value.AsJsonElement);
        }

        /// <summary>
        /// Conversion to byte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a byte.</exception>
        public static explicit operator byte (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetByte();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<byte>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to decimal.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a decimal.</exception>
        public static explicit operator decimal (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetDecimal();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<decimal>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a double.</exception>
        public static explicit operator double (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetDouble();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<double>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int16.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int16.</exception>
        public static explicit operator short (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt16();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<short>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int32.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int32.</exception>
        public static explicit operator int (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt32();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<int>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int64.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int64.</exception>
        public static explicit operator long (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt64();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<long>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int128.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int64.</exception>
        public static explicit operator Int128(NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt128();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<Int128>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to SByte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an SByte.</exception>
        public static explicit operator sbyte (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetSByte();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<sbyte>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Half.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a Single.</exception>
        public static explicit operator Half(NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetHalf();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<Half>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Single.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a Single.</exception>
        public static explicit operator float (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetSingle();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<float>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt16.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt16.</exception>
        public static explicit operator ushort (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt16();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<ushort>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt32.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt32.</exception>
        public static explicit operator uint (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt32();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<uint>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt64.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt64.</exception>
        public static explicit operator ulong (NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt64();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<ulong>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt128.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt64.</exception>
        public static explicit operator UInt128(NonNegativeInteger value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt128();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<UInt128>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion from decimal.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(decimal value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(double value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from Half.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(Half value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from float.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(float value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from byte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(byte value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from short.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(short value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from int.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(int value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from long.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(long value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from sbyte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(sbyte value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from ushort.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(ushort value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from uint.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(uint value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from ulong.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeInteger(ulong value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is less than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator <(in NonNegativeInteger left, in NonNegativeInteger right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) < 0;
        }

        /// <summary>
        /// Greater than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is greater than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator>(in NonNegativeInteger left, in NonNegativeInteger right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) > 0;
        }

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is less than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator <=(in NonNegativeInteger left, in NonNegativeInteger right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) <= 0;
        }

        /// <summary>
        /// Greater than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is greater than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator >=(in NonNegativeInteger left, in NonNegativeInteger right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) >= 0;
        }

        /// <summary>
        /// Adds two values together to compute their sum.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeInteger operator +(NonNegativeInteger left, NonNegativeInteger right)
        {
            return new(left.AsBinaryJsonNumber + right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Subtracts two values together to compute their difference.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeInteger operator -(NonNegativeInteger left, NonNegativeInteger right)
        {
            return new(left.AsBinaryJsonNumber - right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Multiplies two values together.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeInteger operator *(NonNegativeInteger left, NonNegativeInteger right)
        {
            return new(left.AsBinaryJsonNumber * right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Divides two values.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeInteger operator /(NonNegativeInteger left, NonNegativeInteger right)
        {
            return new(left.AsBinaryJsonNumber / right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Increments the value.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeInteger operator ++(NonNegativeInteger value)
        {
            BinaryJsonNumber num = value.AsBinaryJsonNumber;
            return new(num++);
        }

        /// <summary>
        /// Decrements the value.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeInteger operator --(NonNegativeInteger value)
        {
            BinaryJsonNumber num = value.AsBinaryJsonNumber;
            return new(num--);
        }

        /// <summary>
        /// Compare with another number.
        /// </summary>
        /// <param name = "lhs">The lhs of the comparison.</param>
        /// <param name = "rhs">The rhs of the comparison.</param>
        /// <returns>0 if the numbers are equal, -1 if the lhs is less than the rhs, and 1 if the lhs is greater than the rhs.</returns>
        public static int Compare(in NonNegativeInteger lhs, in NonNegativeInteger rhs)
        {
            if (lhs.ValueKind != rhs.ValueKind)
            {
                // We can't be equal if we are not the same underlying type
                return lhs.IsNullOrUndefined() ? 1 : -1;
            }

            if (lhs.IsNull())
            {
                // Nulls are always equal
                return 0;
            }

            if (lhs.backing == Backing.Number && rhs.backing == Backing.Number)
            {
                return BinaryJsonNumber.Compare(lhs.numberBacking, rhs.numberBacking);
            }

            // After this point there is no need to check both value kinds because our first quick test verified that they were the same.
            // If either one is a Backing.Number or a JsonValueKind.Number then we know the rhs is compatible.
            if (lhs.backing == Backing.Number && rhs.backing == Backing.Number)
            {
                return BinaryJsonNumber.Compare(lhs.numberBacking, rhs.numberBacking);
            }

            if (lhs.backing == Backing.Number && rhs.backing == Backing.JsonElement)
            {
                return BinaryJsonNumber.Compare(lhs.numberBacking, rhs.jsonElementBacking);
            }

            if (lhs.backing == Backing.JsonElement && rhs.backing == Backing.Number)
            {
                return BinaryJsonNumber.Compare(lhs.jsonElementBacking, rhs.numberBacking);
            }

            if (lhs.backing == Backing.JsonElement && rhs.backing == Backing.JsonElement && rhs.jsonElementBacking.ValueKind == JsonValueKind.Number)
            {
                return JsonValueHelpers.NumericCompare(lhs.jsonElementBacking, rhs.jsonElementBacking);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public BinaryJsonNumber AsBinaryJsonNumber => this.HasDotnetBacking ? this.numberBacking : BinaryJsonNumber.FromJson(this.jsonElementBacking);
    }
}