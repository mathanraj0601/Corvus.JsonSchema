//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft6 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorConversionsOperators : CodeGeneratorConversionsOperatorsBase {
        
        
        #line 160 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasConversions;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"

    // This is only emitted if HasConversions is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Conversions.Operators should not be emitted if HasConversions is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
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
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 26 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 26 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 28 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 29 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( FormattedTypeDocumentation ));
            
            #line default
            #line hidden
            
            #line 29 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 30 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 30 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 32 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
  foreach(Conversion conversion in Conversions)
    {
        if (conversion.DotnetTypeName == BuiltInTypes.AnyTypeDeclaration.Type)
        {
            // Never emit JsonAny conversions.
            continue;
        } 
            
            #line default
            #line hidden
            
            #line 39 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Conversion to <see cref=\"");
            
            #line default
            #line hidden
            
            #line 41 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 41 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which to co" +
                    "nvert.</param>\r\n    public static explicit operator ");
            
            #line default
            #line hidden
            
            #line 44 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 44 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 44 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 44 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(" value)\r\n    {\r\n        if ((value.backing & Backing.JsonElement) != 0)\r\n        " +
                    "{\r\n            return new(value.AsJsonElement);\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 51 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      // If the conversion supports the given type, we know that
        // we must also support the given type (as we derived the conversion from schema)
        // so we do not need to check the IsImplicitObject etc.
        if(conversion.IsObject)
        { 
            
            #line default
            #line hidden
            
            #line 56 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        if ((value.backing & Backing.Object) != 0)\r\n        {\r\n            retu" +
                    "rn new(value.objectBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 61 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsArray)
        { 
            
            #line default
            #line hidden
            
            #line 64 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        if ((value.backing & Backing.Array) != 0)\r\n        {\r\n            retur" +
                    "n new(value.arrayBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 69 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsString)
        { 
            
            #line default
            #line hidden
            
            #line 72 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        if ((value.backing & Backing.String) != 0)\r\n        {\r\n            retu" +
                    "rn new(value.stringBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 77 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsBoolean)
        { 
            
            #line default
            #line hidden
            
            #line 80 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("        if ((value.backing & Backing.Bool) != 0)\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 82 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
  if (IsImplicitBoolean && !(IsImplicitNumber || IsNotImplicitType))
    { 
            
            #line default
            #line hidden
            
            #line 84 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            return new(value.boolBacking);\r\n");
            
            #line default
            #line hidden
            
            #line 85 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
  }
    else
    { 
            
            #line default
            #line hidden
            
            #line 88 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            return new(value.numberBacking.GetByteAsBool());\r\n");
            
            #line default
            #line hidden
            
            #line 89 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
  } 
            
            #line default
            #line hidden
            
            #line 90 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("        }\r\n");
            
            #line default
            #line hidden
            
            #line 91 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsNumber)
        { 
            
            #line default
            #line hidden
            
            #line 94 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("        if ((value.backing & Backing.Number) != 0)\r\n        {\r\n            return" +
                    " new(value.numberBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 98 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      } 
            
            #line default
            #line hidden
            
            #line 99 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        return ");
            
            #line default
            #line hidden
            
            #line 100 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 100 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(".Undefined;\r\n    }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 103 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
  if (conversion.IsBuiltInPrimitiveType)
    {
        if ((conversion.IsString && IsImplicitString) ||
            (conversion.IsBoolean && IsImplicitBoolean) ||
            (conversion.IsNumber && IsImplicitNumber) ||
            (conversion.IsObject && IsImplicitObject) ||
            (conversion.IsArray && IsImplicitArray))
        {
            // We have already emitted the conversions for this type.
			continue;
        }

    } 
            
            #line default
            #line hidden
            
            #line 116 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Conversion from <see cref=\"");
            
            #line default
            #line hidden
            
            #line 118 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 118 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which to co" +
                    "nvert.</param>\r\n    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 121 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 121 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 121 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 121 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write(" value)\r\n    {\r\n        if (value.HasJsonElementBacking)\r\n        {\r\n            " +
                    "return new(value.AsJsonElement);\r\n        }\r\n\r\n        return value.ValueKind sw" +
                    "itch\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 130 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      // If the conversion supports the given type, we know that
        // we must also support the given type (as we derived the conversion from schema in this case)
        // so we do not need to check the IsImplicitObject etc.
        if(conversion.IsObject)
        { 
            
            #line default
            #line hidden
            
            #line 135 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.Object => new(value.AsPropertyBacking()),\r\n");
            
            #line default
            #line hidden
            
            #line 136 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsArray)
        { 
            
            #line default
            #line hidden
            
            #line 139 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.Array => new(value.AsImmutableList()),\r\n");
            
            #line default
            #line hidden
            
            #line 140 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsString)
        { 
            
            #line default
            #line hidden
            
            #line 143 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.String => new((string)value),\r\n");
            
            #line default
            #line hidden
            
            #line 144 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsBoolean)
        { 
            
            #line default
            #line hidden
            
            #line 147 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.True => new(true),\r\n            JsonValueKind.False => " +
                    "new(false),\r\n");
            
            #line default
            #line hidden
            
            #line 149 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsNumber)
        { 
            
            #line default
            #line hidden
            
            #line 152 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.Number => new(value.AsBinaryJsonNumber),\r\n");
            
            #line default
            #line hidden
            
            #line 153 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
      } 
            
            #line default
            #line hidden
            
            #line 154 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("            _ => Undefined\r\n        };\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 157 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
  } 
            
            #line default
            #line hidden
            
            #line 158 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            
            #line 159 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Conversions.Operators.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorConversionsOperatorsBase {
        
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
