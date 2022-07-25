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

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Applicator
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PropertiesEntity
    {
        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Schema"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Schema value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Schema"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Schema(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Schema.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Core"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Core value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Core"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Core(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Core.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Applicator"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Applicator value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Applicator"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Applicator(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Applicator.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Validation"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Validation value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Validation"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Validation(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Validation.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.MetaData"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.MetaData value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.MetaData"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.MetaData(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.MetaData.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Format"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Format value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Format"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Format(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Format.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Content"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Content value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, JsonAny>)value),
                JsonValueKind.True => new(true),
                JsonValueKind.False => new(false),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Content"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Content(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Object) != 0)
            {
                return new(value.objectBacking);
            }

            if ((value.backing & Backing.Bool) != 0)
            {
                return new(value.boolBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Content.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft201909.Applicator.SchemaArray"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator PropertiesEntity(Corvus.Json.JsonSchema.Draft201909.Applicator.SchemaArray value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Array => new((ImmutableList<JsonAny>)value),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft201909.Applicator.SchemaArray"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft201909.Applicator.SchemaArray(PropertiesEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Array) != 0)
            {
                return new(value.arrayBacking);
            }

            return Corvus.Json.JsonSchema.Draft201909.Applicator.SchemaArray.Undefined;
        }
    }
}