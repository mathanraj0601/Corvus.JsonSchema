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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct AddEntity
    {
        /// <summary>
        /// JSON property name for <see cref = "Op"/>.
        /// </summary>
        public static ReadOnlySpan<byte> OpUtf8JsonPropertyName => "op"u8;

        /// <summary>
        /// JSON property name for <see cref = "Op"/>.
        /// </summary>
        public const string OpJsonPropertyName = "op";
        /// <summary>
        /// JSON property name for <see cref = "Path"/>.
        /// </summary>
        public static ReadOnlySpan<byte> PathUtf8JsonPropertyName => "path"u8;

        /// <summary>
        /// JSON property name for <see cref = "Path"/>.
        /// </summary>
        public const string PathJsonPropertyName = "path";
        /// <summary>
        /// JSON property name for <see cref = "Value"/>.
        /// </summary>
        public static ReadOnlySpan<byte> ValueUtf8JsonPropertyName => "value"u8;

        /// <summary>
        /// JSON property name for <see cref = "Value"/>.
        /// </summary>
        public const string ValueJsonPropertyName = "value";
        /// <summary>
        /// Gets Op.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity.OpEntity Op
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(OpUtf8JsonPropertyName, out JsonElement result))
                    {
                        return new Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity.OpEntity(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(OpJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity.OpEntity>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets Path.
        /// </summary>
        public Corvus.Json.JsonPointer Path
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(PathUtf8JsonPropertyName, out JsonElement result))
                    {
                        return new Corvus.Json.JsonPointer(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(PathJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.JsonPointer>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets Value.
        /// </summary>
        public Corvus.Json.JsonAny Value
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(ValueUtf8JsonPropertyName, out JsonElement result))
                    {
                        return new Corvus.Json.JsonAny(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(ValueJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.JsonAny>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Creates an instance of a <see cref = "AddEntity"/>.
        /// </summary>
        public static AddEntity Create(Corvus.Json.JsonPointer path, Corvus.Json.JsonAny value)
        {
            var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
            builder.Add(OpJsonPropertyName, new Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity.OpEntity().AsAny);
            builder.Add(PathJsonPropertyName, path.AsAny);
            builder.Add(ValueJsonPropertyName, value.AsAny);
            return builder.ToImmutable();
        }

        /// <summary>
        /// Sets path.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public AddEntity WithPath(in Corvus.Json.JsonPointer value)
        {
            return this.SetProperty(PathJsonPropertyName, value);
        }

        /// <summary>
        /// Sets value.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public AddEntity WithValue(in Corvus.Json.JsonAny value)
        {
            return this.SetProperty(ValueJsonPropertyName, value);
        }

        private static ValidationContext __CorvusValidateValue(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.JsonAny>().Validate(validationContext, level);
        }

        private static ValidationContext __CorvusValidateOp(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity.OpEntity>().Validate(validationContext, level);
        }

        /// <summary>
        /// Tries to get the validator for the given property.
        /// </summary>
        /// <param name = "property">The property for which to get the validator.</param>
        /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
        /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
        /// <returns><c>True</c> if the validator was found.</returns>
        private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
        {
            if (hasJsonElementBacking)
            {
                if (property.NameEquals(ValueUtf8JsonPropertyName))
                {
                    propertyValidator = __CorvusValidateValue;
                    return true;
                }
                else if (property.NameEquals(OpUtf8JsonPropertyName))
                {
                    propertyValidator = __CorvusValidateOp;
                    return true;
                }
            }
            else
            {
                if (property.NameEquals(ValueJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateValue;
                    return true;
                }
                else if (property.NameEquals(OpJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateOp;
                    return true;
                }
            }

            propertyValidator = null;
            return false;
        }
    }
}