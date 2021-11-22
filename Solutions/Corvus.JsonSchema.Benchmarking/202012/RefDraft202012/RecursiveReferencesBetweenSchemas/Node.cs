
    //------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace RefDraft202012Feature.RecursiveReferencesBetweenSchemas
{
    using System;
    using System.Collections.Immutable;
    using System.Text;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using Corvus.Json;

        /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly struct Node :
            IJsonObject<Node>,
                    IEquatable<Node>
    {

        
    
        
        /// <summary>
        /// JSON property name for <see cref="Value"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> ValueUtf8JsonPropertyName = new byte[] { 118, 97, 108, 117, 101 };

        /// <summary>
        /// JSON property name for <see cref="Value"/>.
        /// </summary>
        public static readonly string ValueJsonPropertyName = "value";

        
        /// <summary>
        /// JSON property name for <see cref="Subtree"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> SubtreeUtf8JsonPropertyName = new byte[] { 115, 117, 98, 116, 114, 101, 101 };

        /// <summary>
        /// JSON property name for <see cref="Subtree"/>.
        /// </summary>
        public static readonly string SubtreeJsonPropertyName = "subtree";

        
    
    
    
    
    
            private static readonly ImmutableDictionary<string, PropertyValidator<Node>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    
    

    
        private readonly JsonElement jsonElementBacking;

            private readonly ImmutableDictionary<string, JsonAny>? objectBacking;
    
    
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public Node(JsonElement value)
        {
            this.jsonElementBacking = value;
                this.objectBacking = default;
                            }

            /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> struct.
        /// </summary>
        /// <param name="value">A property dictionary.</param>
        public Node(ImmutableDictionary<string, JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.objectBacking = value;
                                        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> struct.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> from which to construct the value.</param>
        public Node(JsonObject jsonObject)
        {
            if (jsonObject.HasJsonElement)
            {
                this.jsonElementBacking = jsonObject.AsJsonElement;
                this.objectBacking = default;
            }
            else
            {
                this.jsonElementBacking = default;
                this.objectBacking = jsonObject.AsPropertyDictionary;
            }

                                        }
    
    
    
    
    
    
    

    
    
    
            
        /// <summary>
        /// Gets Value.
        /// </summary>
        /// <remarks>
        /// {Property title}.
        /// {Property description}.
        /// </remarks>
        /// <example>
        /// {Property examples}.
        /// </example>
        public Corvus.Json.JsonNumber Value
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
                {
                    if(properties.TryGetValue(ValueJsonPropertyName, out JsonAny result))
                    {
                        return result;
                    }
                }

                if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
                {
                    if (this.jsonElementBacking.TryGetProperty(ValueUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new  Corvus.Json.JsonNumber(result);
                    }
                }

                return default;
            }
        }

        
        /// <summary>
        /// Gets Subtree.
        /// </summary>
        /// <remarks>
        /// {Property title}.
        /// {Property description}.
        /// </remarks>
        /// <example>
        /// {Property examples}.
        /// </example>
        public RefDraft202012Feature.RecursiveReferencesBetweenSchemas.Tree Subtree
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
                {
                    if(properties.TryGetValue(SubtreeJsonPropertyName, out JsonAny result))
                    {
                        return result;
                    }
                }

                if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
                {
                    if (this.jsonElementBacking.TryGetProperty(SubtreeUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new  RefDraft202012Feature.RecursiveReferencesBetweenSchemas.Tree(result);
                    }
                }

                return default;
            }
        }

                    /// <summary>
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement =>
    
                this.objectBacking is null
            
    
                
                ;

        /// <summary>
        /// Gets the value as a JsonElement.
        /// </summary>
        public JsonElement AsJsonElement
        {
            get
            {
              
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return JsonObject.PropertiesToJsonElement(objectBacking);
                }

    
    
    
    
    
                return this.jsonElementBacking;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
                    if (this.objectBacking is ImmutableDictionary<string, JsonAny>)
                {
                    return JsonValueKind.Object;
                }

    
    
    
    
    
                return this.jsonElementBacking.ValueKind;
            }
        }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
                    if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return new JsonAny(objectBacking);
                }

    
    
    
    
    
                return new JsonAny(this.jsonElementBacking);
            }
        }

    
        
        /// <summary>
        /// Conversion from any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator Node(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new Node(value.AsJsonElement);
            }

            return value.As<Node>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(Node value)
        {
            return value.AsAny;
        }

    
    
        /// <summary>
        /// Conversion from object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator Node(JsonObject value)
        {
            return new Node(value);
        }

        /// <summary>
        /// Conversion to object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonObject(Node value)
        {
            return value.AsObject;
        }

                /// <summary>
        /// Implicit conversion to a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ImmutableDictionary<string, JsonAny>(Node  value)
        {
            return value.AsObject.AsPropertyDictionary;
        }

        /// <summary>
        /// Implicit conversion from a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator Node (ImmutableDictionary<string, JsonAny> value)
        {
            return new Node (value);
        }

    
    
    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(Node lhs, Node rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(Node lhs, Node rhs)
        {
            return !lhs.Equals(rhs);
        }

    
            /// <summary>
        /// Creates an instance of a <see cref="Node"/>.
        /// </summary>
        public static Node Create(
                   Corvus.Json.JsonNumber value
                ,             RefDraft202012Feature.RecursiveReferencesBetweenSchemas.Tree? subtree = null
        
        )
        {
            var builder = ImmutableDictionary.CreateBuilder<string, JsonAny>();
                    builder.Add(ValueJsonPropertyName, value);
                            if (subtree is RefDraft202012Feature.RecursiveReferencesBetweenSchemas.Tree subtree__)
            {
                builder.Add(SubtreeJsonPropertyName, subtree__);
            }
                    return builder.ToImmutable();
        }

        
        /// <summary>
        /// Sets value.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public Node WithValue(Corvus.Json.JsonNumber value)
        {
            return this.SetProperty(ValueJsonPropertyName, value);
        }

        
        /// <summary>
        /// Sets subtree.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public Node WithSubtree(RefDraft202012Feature.RecursiveReferencesBetweenSchemas.Tree value)
        {
            return this.SetProperty(SubtreeJsonPropertyName, value);
        }

        
    
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is Node entity)
            {
                return this.Equals(entity);
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            JsonValueKind valueKind = this.ValueKind;

            return valueKind switch
            {
                    JsonValueKind.Object => this.AsObject.GetHashCode(),
                        JsonValueKind.Array => this.AsArray().GetHashCode(),
                        JsonValueKind.Number => this.AsNumber().GetHashCode(),
                        JsonValueKind.String => this.AsString().GetHashCode(),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().GetHashCode(),
                    JsonValueKind.Null => JsonNull.NullHashCode,
                _ => JsonAny.UndefinedHashCode,
            };
        }

        /// <summary>
        /// Writes the object to the <see cref="Utf8JsonWriter"/>.
        /// </summary>
        /// <param name="writer">The writer to which to write the object.</param>
        public void WriteTo(Utf8JsonWriter writer)
        {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
            {
                JsonObject.WriteProperties(objectBacking, writer);
                return;
            }

    
    
    
    
    
            if (this.jsonElementBacking.ValueKind != JsonValueKind.Undefined)
            {
                this.jsonElementBacking.WriteTo(writer);
                return;
            }

            writer.WriteNullValue();
        }

    
        
        
        /// <inheritdoc/>
        public JsonObjectEnumerator EnumerateObject()
        {
            return this.AsObject.EnumerateObject();
        }

    
    
    
        /// <inheritdoc/>
        public bool TryGetProperty(string name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(name, out value);
        }

        /// <inheritdoc/>
        public bool TryGetProperty(ReadOnlySpan<char> name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(name, out value);
        }

        /// <inheritdoc/>
        public bool TryGetProperty(ReadOnlySpan<byte> utf8name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(utf8name, out value);
        }

        
    
        /// <inheritdoc/>
        public bool Equals<T>(T other)
            where T : struct, IJsonValue
        {
            JsonValueKind valueKind = this.ValueKind;

            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                    JsonValueKind.Object => this.AsObject.Equals(other.AsObject()),
                        JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

        /// <inheritdoc/>
        public bool Equals(Node other)
        {
            JsonValueKind valueKind = this.ValueKind;

            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                                JsonValueKind.Object => this.AsObject.Equals(other.AsObject),
                        JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

    
        /// <inheritdoc/>
        public bool HasProperty(string name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(name, out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(name.ToString(), out JsonElement _);
            }

            return false;
        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<char> name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(name.ToString(), out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(name, out JsonElement _);
            }

            return false;        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<byte> utf8name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(System.Text.Encoding.UTF8.GetString(utf8name), out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(utf8name, out JsonElement _);
            }

            return false;        }

        /// <inheritdoc/>
        public Node SetProperty<TValue>(string name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public Node SetProperty<TValue>(ReadOnlySpan<char> name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public Node SetProperty<TValue>(ReadOnlySpan<byte> utf8name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(utf8name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public Node RemoveProperty(string name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public Node RemoveProperty(ReadOnlySpan<char> name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public Node RemoveProperty(ReadOnlySpan<byte> utf8Name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(utf8Name);
            }

            return this;
        }

    
    
        /// <inheritdoc/>
        public T As<T>()
            where T : struct, IJsonValue
        {
            return this.As<Node, T>();
        }

        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext? validationContext = null, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext ?? ValidationContext.ValidContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }
        
        

    
                JsonValueKind valueKind = this.ValueKind;
    
    
                    result = this.ValidateType(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }
        
        
        
        
    
    
    
        
    
    
    
    
    
    
                result = this.ValidateObject(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

    

                return result;
        }

            /// <summary>
        /// Gets the value as a <see cref="JsonObject"/>.
        /// </summary>
        private JsonObject AsObject
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return new JsonObject(objectBacking);
                }

                return new JsonObject(this.jsonElementBacking);
            }
        }
    
    
    
    
    
    
    
    
    
    
        private static ImmutableDictionary<string, PropertyValidator<Node>> CreateLocalPropertyValidators()
        {
            ImmutableDictionary<string, PropertyValidator<Node>>.Builder builder =
                ImmutableDictionary.CreateBuilder<string, PropertyValidator<Node>>();

                    builder.Add(
                ValueJsonPropertyName, __CorvusValidateValue);
                    builder.Add(
                SubtreeJsonPropertyName, __CorvusValidateSubtree);
        
            return builder.ToImmutable();
        }

                private static ValidationContext __CorvusValidateValue(in Node that, in ValidationContext validationContext, ValidationLevel level)
        {
            Corvus.Json.JsonNumber property = that.Value;
            return property.Validate(validationContext, level);
        }
                private static ValidationContext __CorvusValidateSubtree(in Node that, in ValidationContext validationContext, ValidationLevel level)
        {
            RefDraft202012Feature.RecursiveReferencesBetweenSchemas.Tree property = that.Subtree;
            return property.Validate(validationContext, level);
        }
            
    
    
            private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;

            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

                    int propertyCount = 0;
        
                                bool foundValue = false;
                    
            foreach (Property property in this.EnumerateObject())
            {
                string propertyName = property.Name;

        
                        if (__CorvusLocalProperties.TryGetValue(propertyName, out PropertyValidator<Node>? propertyValidator))
                {
                    result = result.WithLocalProperty(propertyCount);
                    var propertyResult = propertyValidator(this, result.CreateChildContext(), level);
                    result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

            
                if (ValueJsonPropertyName.Equals(propertyName))
                {
                    foundValue = true;
                }
            
                }
        
        
        
        
        
        
                
                propertyCount++;

                    }

        
                        if (!foundValue)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.5.3. required - required property \"value\" not present.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "6.5.3. required - required property not present.");
                }
                else
                {
                    return result.WithResult(isValid: false);
                }
            }
                    
        
        
            return result;
        }

    
            

            

            

            

    
    
    
            
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;

        
                
            ValidationContext localResultObject = Corvus.Json.Validate.TypeObject(valueKind, result, level);
            if (level == ValidationLevel.Flag && localResultObject.IsValid)
            {
                return validationContext;
            }

            if (localResultObject.IsValid)
            {
                isValid = true;
            }

        
        
        
        
        
        
            result = result.MergeResults(
                isValid,
                level
        
                
                , localResultObject
        
        
        
        
        
                        );

            return result;
        }

    
    
    
    }
    }
    