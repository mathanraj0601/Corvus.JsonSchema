// <copyright file="JsonOptional{T}.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Text.Json;

namespace Corvus.Json;

/// <summary>
/// Represents a JSON property value that might be optional.
/// </summary>
/// <typeparam name="T">The type of the value.</typeparam>
public readonly struct JsonOptional<T>
    where T : struct, IJsonValue<T>
{
    private readonly T backing;

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonOptional{T}"/> class.
    /// </summary>
    /// <param name="value">The potentially optional value.</param>
    public JsonOptional(in T value)
    {
        this.backing = value;
    }

    /// <summary>
    /// Gets a value indicating whether this optional value is present.
    /// </summary>
    /// <remarks>
    /// Note that this determines that the value is not <see cref="JsonValueKind.Undefined"/>. If the value
    /// may be <see cref="JsonValueKind.Null"/> then this will still return <see langword="true"/>.
    /// </remarks>
    public bool HasValue => this.backing.ValueKind != JsonValueKind.Undefined;

    /// <summary>
    /// Gets the value.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown if the optional value is undefined.</exception>
    public T Value
    {
        get
        {
            if (!this.HasValue)
            {
                throw new InvalidOperationException("The optional value is undefined.");
            }

            return this.backing;
        }
    }

    /// <summary>
    /// Explicit conversion to the value.
    /// </summary>
    /// <param name="value">The optional backing value to convert.</param>
    public static explicit operator T(JsonOptional<T> value) => value.backing;

    /// <summary>
    /// Implicit conversion to an optional value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public static implicit operator JsonOptional<T>(T value) => new(value);

    /// <summary>
    /// Gets the value of the current instance, or a default value.
    /// </summary>
    /// <returns>The value of the <see cref="Value"/> property if the <see cref="HasValue"/> property is <see langword="true"/>; otherwise, the default value of the underlying type.</returns>
    public T GetValueOrDefault()
    {
        return this.HasValue ? this.backing : default;
    }

    /// <summary>
    /// Gets the value of the current instance, or a default value.
    /// </summary>
    /// <param name="defaultValue">The default value to use if <see cref="HasValue"/> is <see langword="false"/>.</param>
    /// <returns>The value of the <see cref="Value"/> property if the <see cref="HasValue"/> property is <see langword="true"/>; otherwise, the supplied <paramref name="defaultValue"/>.</returns>
    public readonly T GetValueOrDefault(in T defaultValue) => this.HasValue ? this.backing : defaultValue;

    /// <inheritdoc/>
    public override bool Equals(object? other)
    {
        if (!this.HasValue)
        {
            return other == null;
        }

        if (other is T value)
        {
            return this.backing.Equals(value);
        }

        return false;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => this.HasValue ? this.backing.GetHashCode() : 0;

    /// <inheritdoc/>
    public override string? ToString() => this.HasValue ? this.backing.ToString() : string.Empty;
}