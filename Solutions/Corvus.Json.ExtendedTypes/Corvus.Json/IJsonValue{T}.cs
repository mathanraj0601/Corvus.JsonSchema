﻿// <copyright file="IJsonValue{T}.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Buffers;
using System.Text.Json;

namespace Corvus.Json;

/// <summary>
/// Interface implemented by all JSON values.
/// </summary>
/// <typeparam name="T">The type implementing the interface.</typeparam>
public interface IJsonValue<T> : IEquatable<T>, IJsonValue
    where T : struct, IJsonValue<T>
{
    /// <summary>
    /// Gets the null value.
    /// </summary>
    static abstract T Null { get; }

    /// <summary>
    /// Gets the undefined value.
    /// </summary>
    static abstract T Undefined { get; }

    /// <summary>
    /// Gets an instance of the JSON value from a JsonAny value.
    /// </summary>
    /// <param name="value">The <see cref="JsonAny"/> value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the <see cref="JsonAny"/>.</returns>
    /// <remarks>The returned value will have a <see cref="IJsonValue.ValueKind"/> of <see cref="JsonValueKind.Undefined"/> if the
    /// value cannot be constructed from the given instance (e.g. because they have an incompatible dotnet backing type.
    /// </remarks>
    static abstract T FromAny(in JsonAny value);

    /// <summary>
    /// Gets an instance of the JSON value from a <see cref="JsonElement"/> value.
    /// </summary>
    /// <param name="value">The <see cref="JsonElement"/> value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the <see cref="JsonElement"/>.</returns>
    static abstract T FromJson(in JsonElement value);

    /// <summary>
    /// Gets an instance of the JSON value from a string value.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>The value will be undefined if it does not support the type.</remarks>
    static abstract T FromString<TValue>(in TValue value)
        where TValue : struct, IJsonString<TValue>;

    /// <summary>
    /// Gets an instance of the JSON value from a boolean value.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>The value will be undefined if it does not support the type.</remarks>
    static abstract T FromBoolean<TValue>(in TValue value)
        where TValue : struct, IJsonBoolean<TValue>;

    /// <summary>
    /// Gets an instance of the JSON value from a double value.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>The value will be undefined if it does not support the type.</remarks>
    static abstract T FromNumber<TValue>(in TValue value)
        where TValue : struct, IJsonNumber<TValue>;

    /// <summary>
    /// Gets an instance of the JSON value from an array value.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>The value will be undefined if it does not support the type.</remarks>
    static abstract T FromArray<TValue>(in TValue value)
        where TValue : struct, IJsonArray<TValue>;

    /// <summary>
    /// Gets an instance of the JSON value from an object value.
    /// </summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>The value will be undefined if it does not support the type.</remarks>
    static abstract T FromObject<TValue>(in TValue value)
        where TValue : struct, IJsonObject<TValue>;

    /// <summary>
    /// Parses a JSON string.
    /// </summary>
    /// <param name="json">The json string to parse.</param>
    /// <param name="options">The (optional) JsonDocumentOptions.</param>
    /// <returns>An instance built from the JSON string.</returns>
    static abstract T Parse(string json, JsonDocumentOptions options = default);

    /// <summary>
    /// Parses a JSON string.
    /// </summary>
    /// <param name="utf8Json">The json string to parse.</param>
    /// <param name="options">The (optional) JsonDocumentOptions.</param>
    /// <returns>An instance built from the JSON string.</returns>
    static abstract T Parse(Stream utf8Json, JsonDocumentOptions options = default);

    /// <summary>
    /// Parses a JSON string.
    /// </summary>
    /// <param name="utf8Json">The json string to parse.</param>
    /// <param name="options">The (optional) JsonDocumentOptions.</param>
    /// <returns>An instance built from the JSON string.</returns>
    static abstract T Parse(ReadOnlyMemory<byte> utf8Json, JsonDocumentOptions options = default);

    /// <summary>
    /// Parses a JSON string.
    /// </summary>
    /// <param name="json">The json string to parse.</param>
    /// <param name="options">The (optional) JsonDocumentOptions.</param>
    /// <returns>An instance built from the JSON string.</returns>
    static abstract T Parse(ReadOnlyMemory<char> json, JsonDocumentOptions options = default);

    /// <summary>
    /// Parses a JSON string.
    /// </summary>
    /// <param name="utf8Json">The json string to parse.</param>
    /// <param name="options">The (optional) JsonDocumentOptions.</param>
    /// <returns>An instance built from the JSON string.</returns>
    static abstract T Parse(ReadOnlySequence<byte> utf8Json, JsonDocumentOptions options = default);
}