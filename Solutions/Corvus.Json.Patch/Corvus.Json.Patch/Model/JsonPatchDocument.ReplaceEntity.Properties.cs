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
    public readonly partial struct ReplaceEntity
    {
        /// <summary>
        /// JSON property name for <see cref = "Value"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> ValueUtf8JsonPropertyName = new byte[]{118, 97, 108, 117, 101};
        /// <summary>
        /// JSON property name for <see cref = "Value"/>.
        /// </summary>
        public const string ValueJsonPropertyName = "value";
        /// <summary>
        /// JSON property name for <see cref = "Path"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> PathUtf8JsonPropertyName = new byte[]{112, 97, 116, 104};
        /// <summary>
        /// JSON property name for <see cref = "Path"/>.
        /// </summary>
        public const string PathJsonPropertyName = "path";
        /// <summary>
        /// JSON property name for <see cref = "Op"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> OpUtf8JsonPropertyName = new byte[]{111, 112};
        /// <summary>
        /// JSON property name for <see cref = "Op"/>.
        /// </summary>
        public const string OpJsonPropertyName = "op";
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

                    if (this.jsonElementBacking.TryGetProperty(ValueUtf8JsonPropertyName.Span, out JsonElement result))
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

                    if (this.jsonElementBacking.TryGetProperty(PathUtf8JsonPropertyName.Span, out JsonElement result))
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
        /// Gets Op.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity.OpEntity Op
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(OpUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity.OpEntity(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(OpJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity.OpEntity>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Creates an instance of a <see cref = "ReplaceEntity"/>.
        /// </summary>
        public static ReplaceEntity Create(Corvus.Json.JsonAny value, Corvus.Json.JsonPointer path)
        {
            var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
            builder.Add(ValueJsonPropertyName, value.AsAny);
            builder.Add(PathJsonPropertyName, path.AsAny);
            builder.Add(OpJsonPropertyName, new Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity.OpEntity().AsAny);
            return builder.ToImmutable();
        }

        /// <summary>
        /// Sets value.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public ReplaceEntity WithValue(in Corvus.Json.JsonAny value)
        {
            return this.SetProperty(ValueJsonPropertyName, value);
        }

        /// <summary>
        /// Sets path.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public ReplaceEntity WithPath(in Corvus.Json.JsonPointer value)
        {
            return this.SetProperty(PathJsonPropertyName, value);
        }

        private static ValidationContext __CorvusValidateValue(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.JsonAny>().Validate(validationContext, level);
        }

        private static ValidationContext __CorvusValidateOp(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity.OpEntity>().Validate(validationContext, level);
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
                if (property.NameEquals(ValueUtf8JsonPropertyName.Span))
                {
                    propertyValidator = __CorvusValidateValue;
                    return true;
                }
                else if (property.NameEquals(OpUtf8JsonPropertyName.Span))
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