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
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Patch.Model;
/// <summary>
/// A type generated from a JsonSchema() specification.
/// </summary>
public readonly partial struct PatchOperation
{
    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.PatchOperationCommon"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.PatchOperationCommon value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.PatchOperationCommon"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.PatchOperationCommon(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.PatchOperationCommon.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.Add"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.Add value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.Add"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.Add(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.Add.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.Remove"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.Remove value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.Remove"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.Remove(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.Remove.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.Replace"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.Replace value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.Replace"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.Replace(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.Replace.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.Move"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.Move value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.Move"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.Move(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.Move.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.Copy"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.Copy value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.Copy"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.Copy(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.Copy.Undefined;
    }

    /// <summary>
    /// Conversion from <see cref = "Corvus.Json.Patch.Model.Test"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator PatchOperation(Corvus.Json.Patch.Model.Test value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return value.ValueKind switch
        {
            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
            _ => Undefined
        };
    }

    /// <summary>
    /// Conversion to <see cref = "Corvus.Json.Patch.Model.Test"/>.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Corvus.Json.Patch.Model.Test(PatchOperation value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return new(value.AsJsonElement);
        }

        if ((value.backing & Backing.Object) != 0)
        {
            return new(value.objectBacking);
        }

        return Corvus.Json.Patch.Model.Test.Undefined;
    }
}