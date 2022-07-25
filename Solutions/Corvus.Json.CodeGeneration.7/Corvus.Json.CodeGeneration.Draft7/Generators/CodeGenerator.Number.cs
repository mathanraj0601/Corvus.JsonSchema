//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft7 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorNumber : CodeGeneratorNumberBase {
        
        
        #line 396 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"

    public bool ShouldGenerate
    {
        get
        {
            return IsImplicitNumber || IsNotImplicitType;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"

    // This is only emitted if IsImplicitNumber is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Number should not be emitted if IsImplicitString is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(" : IJsonNumber<");
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(">\r\n{\r\n   /// <summary>\r\n    /// Initializes a new instance of the <see cref=\"");
            
            #line default
            #line hidden
            
            #line 36 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 36 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("\"/> struct.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which" +
                    " to construct the instance.</param>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 39 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 39 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("(double value)\r\n    {\r\n        this.jsonElementBacking = default;\r\n        this.b" +
                    "acking = Backing.Number;\r\n        this.numberBacking = value;\r\n");
            
            #line default
            #line hidden
            
            #line 44 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
  if(IsImplicitBoolean || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 46 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("        this.boolBacking = default;\r\n");
            
            #line default
            #line hidden
            
            #line 47 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
  }
    if(IsImplicitString || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("        this.stringBacking = string.Empty;\r\n");
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
  }
    if(IsImplicitArray || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 54 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("        this.arrayBacking = ImmutableList<JsonAny>.Empty;\r\n");
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
  }
    if(IsImplicitObject || IsNotImplicitType)
    { 
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("        this.objectBacking = ImmutableDictionary<JsonPropertyName, JsonAny>.Empty" +
                    ";\r\n");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
  } 
            
            #line default
            #line hidden
            
            #line 60 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write("    }\r\n\r\n    /// <summary>\r\n    /// Conversion from JsonNumber.\r\n    /// </summar" +
                    "y>\r\n    /// <param name=\"value\">The value from which to convert.</param>\r\n    pu" +
                    "blic static implicit operator JsonNumber(");
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(" value)\r\n    {\r\n        return value.AsNumber;\r\n    }\r\n\r\n    /// <summary>\r\n    /" +
                    "// Conversion to JsonNumber.\r\n    /// </summary>\r\n    /// <param name=\"value\">Th" +
                    "e value from which to convert.</param>\r\n    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 75 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(JsonNumber value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return new((double)value);
    }

    /// <summary>
    /// Conversion from double.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 89 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(double value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to double.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a double.</exception>
    public static implicit operator double(");
            
            #line default
            #line hidden
            
            #line 100 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 100 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetDouble();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            return value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from float.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 119 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 119 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(float value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to double.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a float.</exception>
    public static implicit operator float(");
            
            #line default
            #line hidden
            
            #line 130 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 130 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetSingle();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < float.MinValue || value.numberBacking > float.MaxValue)
            {
                throw new FormatException();
            }

            return (float)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from int.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 154 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 154 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(int value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to int.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a int.</exception>
    public static implicit operator int(");
            
            #line default
            #line hidden
            
            #line 165 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 165 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetInt32();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < int.MinValue || value.numberBacking > int.MaxValue)
            {
                throw new FormatException();
            }

            return (int)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from long.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 189 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 189 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(long value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to long.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a long.</exception>
    public static implicit operator long(");
            
            #line default
            #line hidden
            
            #line 200 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 200 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetInt64();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < long.MinValue || value.numberBacking > long.MaxValue)
            {
                throw new FormatException();
            }

            return (long)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from uint.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static explicit operator ");
            
            #line default
            #line hidden
            
            #line 224 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 224 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(uint value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to uint.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a uint.</exception>
    public static implicit operator uint(");
            
            #line default
            #line hidden
            
            #line 235 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 235 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetUInt32();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < uint.MinValue || value.numberBacking > uint.MaxValue)
            {
                throw new FormatException();
            }

            return (uint)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from ushort.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 259 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 259 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(ushort value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to ushort.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a ushort.</exception>
    public static implicit operator ushort(");
            
            #line default
            #line hidden
            
            #line 270 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 270 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetUInt16();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < ushort.MinValue || value.numberBacking > ushort.MaxValue)
            {
                throw new FormatException();
            }

            return (ushort)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from ulong.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 294 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 294 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(ulong value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to ulong.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a ulong.</exception>
    public static implicit operator ulong(");
            
            #line default
            #line hidden
            
            #line 305 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 305 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetUInt64();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < ulong.MinValue || value.numberBacking > ulong.MaxValue)
            {
                throw new FormatException();
            }

            return (ulong)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from byte.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 329 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 329 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(byte value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to byte.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as a byte.</exception>
    public static implicit operator byte(");
            
            #line default
            #line hidden
            
            #line 340 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 340 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetByte();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < byte.MinValue || value.numberBacking > byte.MaxValue)
            {
                throw new FormatException();
            }

            return (byte)value.numberBacking;
        }

        throw new InvalidOperationException();
    }

    /// <summary>
    /// Conversion from sbyte.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 364 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 364 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@"(sbyte value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to sbyte.
    /// </summary>
    /// <param name=""value"">The value to convert.</param>
    /// <exception cref=""InvalidOperationException"">The value was not a number.</exception>
    /// <exception cref=""FormatException"">The value was not formatted as an sbyte.</exception>
    public static implicit operator sbyte(");
            
            #line default
            #line hidden
            
            #line 375 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 375 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
            this.Write(@" value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetSByte();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            if (value.numberBacking < sbyte.MinValue || value.numberBacking > sbyte.MaxValue)
            {
                throw new FormatException();
            }

            return (sbyte)value.numberBacking;
        }

        throw new InvalidOperationException();
    }
}
");
            
            #line default
            #line hidden
            
            #line 395 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Number.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorNumberBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
