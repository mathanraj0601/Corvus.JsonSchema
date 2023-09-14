//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Buffers;
using System.ComponentModel;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
[System.Text.Json.Serialization.JsonConverter(typeof(Corvus.Json.Internal.JsonValueConverter<Content>))]
public readonly partial struct Content
{
    private readonly Backing backing;
    private readonly JsonElement jsonElementBacking;
    private readonly bool boolBacking;
    private readonly ImmutableDictionary<JsonPropertyName, JsonAny> objectBacking;
    /// <summary>
    /// Initializes a new instance of the <see cref = "Content"/> struct.
    /// </summary>
    public Content()
    {
        this.jsonElementBacking = default;
        this.backing = Backing.JsonElement;
        this.boolBacking = default;
        this.objectBacking = ImmutableDictionary<JsonPropertyName, JsonAny>.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref = "Content"/> struct.
    /// </summary>
    /// <param name = "value">The value from which to construct the instance.</param>
    public Content(in JsonElement value)
    {
        this.jsonElementBacking = value;
        this.backing = Backing.JsonElement;
        this.boolBacking = default;
        this.objectBacking = ImmutableDictionary<JsonPropertyName, JsonAny>.Empty;
    }

    /// <summary>
    /// Gets a Null instance.
    /// </summary>
    public static Content Null { get; } = new(JsonValueHelpers.NullElement);
    /// <summary>
    /// Gets an Undefined instance.
    /// </summary>
    public static Content Undefined { get; }
    /// <summary>
    /// Gets the default instance of the type.
    /// </summary>
    public static Content DefaultInstance { get; }

    /// <inheritdoc/>
    public JsonAny AsAny
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Bool) != 0)
            {
                return new(this.boolBacking);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return new(this.objectBacking);
            }

            if ((this.backing & Backing.Null) != 0)
            {
                return JsonAny.Null;
            }

            return JsonAny.Undefined;
        }
    }

    /// <inheritdoc/>
    public JsonElement AsJsonElement
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return this.jsonElementBacking;
            }

            if ((this.backing & Backing.Bool) != 0)
            {
                return JsonValueHelpers.BoolToJsonElement(this.boolBacking);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return JsonValueHelpers.ObjectToJsonElement(this.objectBacking);
            }

            if ((this.backing & Backing.Null) != 0)
            {
                return JsonValueHelpers.NullElement;
            }

            return default;
        }
    }

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public JsonString AsString
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            throw new InvalidOperationException();
        }
    }

    /// <inheritdoc/>
    public JsonBoolean AsBoolean
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Bool) != 0)
            {
                return new(this.boolBacking);
            }

            throw new InvalidOperationException();
        }
    }

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public JsonNumber AsNumber
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            throw new InvalidOperationException();
        }
    }

    /// <inheritdoc/>
    public JsonObject AsObject
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return new(this.objectBacking);
            }

            throw new InvalidOperationException();
        }
    }

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public JsonArray AsArray
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return new(this.jsonElementBacking);
            }

            throw new InvalidOperationException();
        }
    }

    /// <inheritdoc/>
    public bool HasJsonElementBacking
    {
        get
        {
            return (this.backing & Backing.JsonElement) != 0;
        }
    }

    /// <inheritdoc/>
    public bool HasDotnetBacking
    {
        get
        {
            return (this.backing & Backing.Dotnet) != 0;
        }
    }

    /// <inheritdoc/>
    public JsonValueKind ValueKind
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                return this.jsonElementBacking.ValueKind;
            }

            if ((this.backing & Backing.Bool) != 0)
            {
                return this.boolBacking ? JsonValueKind.True : JsonValueKind.False;
            }

            if ((this.backing & Backing.Object) != 0)
            {
                return JsonValueKind.Object;
            }

            if ((this.backing & Backing.Null) != 0)
            {
                return JsonValueKind.Null;
            }

            return JsonValueKind.Undefined;
        }
    }

    /// <summary>
    /// Conversion from JsonAny.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Content(JsonAny value)
    {
        return Content.FromAny(value);
    }

    /// <summary>
    /// Conversion to JsonAny.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    /// <exception cref = "InvalidOperationException">The value was not compatible with this type.</exception>
    public static implicit operator JsonAny(in Content value)
    {
        return value.AsAny;
    }

    /// <summary>
    /// Equality operator.
    /// </summary>
    /// <param name = "left">The lhs.</param>
    /// <param name = "right">The rhs.</param>
    /// <returns><c>True</c> if the values are equal.</returns>
    public static bool operator ==(in Content left, in Content right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Inequality operator.
    /// </summary>
    /// <param name = "left">The lhs.</param>
    /// <param name = "right">The rhs.</param>
    /// <returns><c>True</c> if the values are equal.</returns>
    public static bool operator !=(in Content left, in Content right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    /// Gets an instance of the JSON value from a JsonAny value.
    /// </summary>
    /// <param name = "value">The <see cref = "JsonAny"/> value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the <see cref = "JsonAny"/>.</returns>
    /// <remarks>The returned value will have a <see cref = "IJsonValue.ValueKind"/> of <see cref = "JsonValueKind.Undefined"/> if the
    /// value cannot be constructed from the given instance (e.g. because they have an incompatible dotnet backing type.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Content FromAny(in JsonAny value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        JsonValueKind valueKind = value.ValueKind;
        return valueKind switch
        {
            JsonValueKind.True => new(true),
            JsonValueKind.False => new(false),
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            JsonValueKind.Null => Null,
            _ => Undefined,
        };
    }

    /// <summary>
    /// Gets an instance of the JSON value from a <see cref = "JsonElement"/> value.
    /// </summary>
    /// <param name = "value">The <see cref = "JsonElement"/> value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the <see cref = "JsonElement"/>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Content FromJson(in JsonElement value)
    {
        return new(value);
    }

    /// <summary>
    /// Gets an instance of the JSON value from a boolean value.
    /// </summary>
    /// <typeparam name = "TValue">The type of the value.</typeparam>
    /// <param name = "value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>This will be Content.Undefined if the type is not compatible.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Content FromBoolean<TValue>(in TValue value)
        where TValue : struct, IJsonBoolean<TValue>
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        if (value.ValueKind == JsonValueKind.True)
        {
            return new(true);
        }

        if (value.ValueKind == JsonValueKind.False)
        {
            return new(false);
        }

        return Undefined;
    }

    /// <summary>
    /// Gets an instance of the JSON value from a string value.
    /// </summary>
    /// <typeparam name = "TValue">The type of the value.</typeparam>
    /// <param name = "value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>This will be Content.Undefined if the type is not compatible.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static Content FromString<TValue>(in TValue value)
        where TValue : struct, IJsonString<TValue>
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return Undefined;
    }

    /// <summary>
    /// Gets an instance of the JSON value from a number value.
    /// </summary>
    /// <typeparam name = "TValue">The type of the value.</typeparam>
    /// <param name = "value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>This will be Content.Undefined if the type is not compatible.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static Content FromNumber<TValue>(in TValue value)
        where TValue : struct, IJsonNumber<TValue>
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return Undefined;
    }

    /// <summary>
    /// Gets an instance of the JSON value from an array value.
    /// </summary>
    /// <typeparam name = "TValue">The type of the value.</typeparam>
    /// <param name = "value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>This will be Content.Undefined if the type is not compatible.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static Content FromArray<TValue>(in TValue value)
        where TValue : struct, IJsonArray<TValue>
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return Undefined;
    }

    /// <summary>
    /// Gets an instance of the JSON value from an object value.
    /// </summary>
    /// <typeparam name = "TValue">The type of the value.</typeparam>
    /// <param name = "value">The value from which to instantiate the instance.</param>
    /// <returns>An instance of this type, initialized from the value.</returns>
    /// <remarks>This will be Content.Undefined if the type is not compatible.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Content FromObject<TValue>(in TValue value)
        where TValue : struct, IJsonObject<TValue>
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        if (value.ValueKind == JsonValueKind.Object)
        {
            return new((ImmutableDictionary<JsonPropertyName, JsonAny>)value);
        }

        return Undefined;
    }

    /// <summary>
    /// Parses a JSON string into a Content.
    /// </summary>
    /// <param name = "json">The json string to parse.</param>
    /// <param name = "options">The (optional) JsonDocumentOptions.</param>
    /// <returns>A <see cref = "Content"/> instance built from the JSON string.</returns>
    public static Content Parse(string json, JsonDocumentOptions options = default)
    {
        using var jsonDocument = JsonDocument.Parse(json, options);
        return new Content(jsonDocument.RootElement.Clone());
    }

    /// <summary>
    /// Parses a JSON string into a Content.
    /// </summary>
    /// <param name = "utf8Json">The json string to parse.</param>
    /// <param name = "options">The (optional) JsonDocumentOptions.</param>
    /// <returns>A <see cref = "Content"/> instance built from the JSON string.</returns>
    public static Content Parse(Stream utf8Json, JsonDocumentOptions options = default)
    {
        using var jsonDocument = JsonDocument.Parse(utf8Json, options);
        return new Content(jsonDocument.RootElement.Clone());
    }

    /// <summary>
    /// Parses a JSON string into a Content.
    /// </summary>
    /// <param name = "utf8Json">The json string to parse.</param>
    /// <param name = "options">The (optional) JsonDocumentOptions.</param>
    /// <returns>A <see cref = "Content"/> instance built from the JSON string.</returns>
    public static Content Parse(ReadOnlyMemory<byte> utf8Json, JsonDocumentOptions options = default)
    {
        using var jsonDocument = JsonDocument.Parse(utf8Json, options);
        return new Content(jsonDocument.RootElement.Clone());
    }

    /// <summary>
    /// Parses a JSON string into a Content.
    /// </summary>
    /// <param name = "json">The json string to parse.</param>
    /// <param name = "options">The (optional) JsonDocumentOptions.</param>
    /// <returns>A <see cref = "Content"/> instance built from the JSON string.</returns>
    public static Content Parse(ReadOnlyMemory<char> json, JsonDocumentOptions options = default)
    {
        using var jsonDocument = JsonDocument.Parse(json, options);
        return new Content(jsonDocument.RootElement.Clone());
    }

    /// <summary>
    /// Parses a JSON string into a Content.
    /// </summary>
    /// <param name = "utf8Json">The json string to parse.</param>
    /// <param name = "options">The (optional) JsonDocumentOptions.</param>
    /// <returns>A <see cref = "Content"/> instance built from the JSON string.</returns>
    public static Content Parse(ReadOnlySequence<byte> utf8Json, JsonDocumentOptions options = default)
    {
        using var jsonDocument = JsonDocument.Parse(utf8Json, options);
        return new Content(jsonDocument.RootElement.Clone());
    }

    /// <summary>
    /// Parses a JSON value from a buffer.
    /// </summary>
    /// <param name = "buffer">The buffer from which to parse the value.</param>
    /// <returns>The parsed value.</returns>
    static Content ParseValue(ReadOnlySpan<char> buffer)
    {
        return IJsonValue<Content>.ParseValue(buffer);
    }

    /// <summary>
    /// Parses a JSON value from a buffer.
    /// </summary>
    /// <param name = "buffer">The buffer from which to parse the value.</param>
    /// <returns>The parsed value.</returns>
    static Content ParseValue(ReadOnlySpan<byte> buffer)
    {
        return IJsonValue<Content>.ParseValue(buffer);
    }

    /// <summary>
    /// Parses a JSON value from a buffer.
    /// </summary>
    /// <param name = "reader">The reader from which to parse the value.</param>
    /// <returns>The parsed value.</returns>
    static Content ParseValue(ref Utf8JsonReader reader)
    {
        return IJsonValue<Content>.ParseValue(ref reader);
    }

    /// <summary>
    /// Gets the value as the target value.
    /// </summary>
    /// <typeparam name = "TTarget">The type of the target.</typeparam>
    /// <returns>An instance of the target type.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public TTarget As<TTarget>()
        where TTarget : struct, IJsonValue<TTarget>
    {
        if ((this.backing & Backing.JsonElement) != 0)
        {
            return TTarget.FromJson(this.jsonElementBacking);
        }

        if ((this.backing & Backing.Bool) != 0)
        {
            return TTarget.FromBoolean(this);
        }

        if ((this.backing & Backing.Object) != 0)
        {
            return TTarget.FromObject(this);
        }

        if ((this.backing & Backing.Null) != 0)
        {
            return TTarget.Null;
        }

        return TTarget.Undefined;
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return (obj is IJsonValue jv && this.Equals(jv.AsAny)) || (obj is null && this.IsNull());
    }

    /// <inheritdoc/>
    public bool Equals<T>(T other)
        where T : struct, IJsonValue<T>
    {
        return JsonValueHelpers.CompareValues(this, other);
    }

    /// <inheritdoc/>
    public bool Equals(Content other)
    {
        return JsonValueHelpers.CompareValues(this, other);
    }

    /// <inheritdoc/>
    public void WriteTo(Utf8JsonWriter writer)
    {
        if ((this.backing & Backing.JsonElement) != 0)
        {
            if (this.jsonElementBacking.ValueKind != JsonValueKind.Undefined)
            {
                this.jsonElementBacking.WriteTo(writer);
            }

            return;
        }

        if ((this.backing & Backing.Bool) != 0)
        {
            writer.WriteBooleanValue(this.boolBacking);
            return;
        }

        if ((this.backing & Backing.Object) != 0)
        {
            JsonValueHelpers.WriteProperties(this.objectBacking, writer);
            return;
        }

        if ((this.backing & Backing.Null) != 0)
        {
            writer.WriteNullValue();
            return;
        }
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return JsonValueHelpers.GetHashCode(this);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return this.Serialize();
    }
}