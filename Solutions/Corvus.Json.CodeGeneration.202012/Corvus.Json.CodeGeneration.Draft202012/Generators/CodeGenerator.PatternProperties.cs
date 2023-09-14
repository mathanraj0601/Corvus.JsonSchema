//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.11
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft202012 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorPatternProperties : CodeGeneratorPatternPropertiesBase {
        
        
        #line 106 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasPatternProperties;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"

    // This is only emitted if HasPatternProperties is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.PatternProperties should not be emitted if HasPatternProperties is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
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
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 28 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 28 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 31 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 36 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  foreach(var patternProperty in PatternProperties)
    {
            
            #line default
            #line hidden
            
            #line 38 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("    /// <summary>\r\n    /// A pattern property matching ");
            
            #line default
            #line hidden
            
            #line 39 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(patternProperty.Pattern, true).Trim('"')));
            
            #line default
            #line hidden
            
            #line 39 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" producing a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 39 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 39 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    public static Regex PatternProperty");
            
            #line default
            #line hidden
            
            #line 41 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 41 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" => new(");
            
            #line default
            #line hidden
            
            #line 41 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(patternProperty.Pattern, true) ));
            
            #line default
            #line hidden
            
            #line 41 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(", RegexOptions.Compiled, TimeSpan.FromSeconds(1));\r\n");
            
            #line default
            #line hidden
            
            #line 42 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 43 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\r\n    private static readonly ImmutableDictionary<Regex, PatternPropertyValidator" +
                    "> __CorvusPatternProperties = CreatePatternPropertiesValidators();\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 46 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  foreach(var patternProperty in PatternProperties)
    { 
            
            #line default
            #line hidden
            
            #line 48 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("    /// <summary>\r\n    /// Determines if a property matches ");
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(patternProperty.Pattern, true).Trim('"')));
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" producing a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    public bool MatchesPattern");
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("(in JsonObjectProperty property)\r\n    {\r\n        return PatternProperty");
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(".IsMatch(property.Name);\r\n    }\r\n\r\n    /// <summary>\r\n    /// Get a property valu" +
                    "e as the type matching the given pattern property ");
            
            #line default
            #line hidden
            
            #line 57 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(patternProperty.Pattern, true).Trim('"')));
            
            #line default
            #line hidden
            
            #line 57 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" as a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 57 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 57 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    public bool TryAsPattern");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("(in JsonObjectProperty property, out  ");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" result)\r\n    {\r\n        if (PatternProperty");
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 61 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(".IsMatch(property.Name))\r\n        {\r\n            result = property.ValueAs<");
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(">();\r\n            return true;\r\n        }\r\n        else\r\n        {\r\n            r" +
                    "esult = ");
            
            #line default
            #line hidden
            
            #line 68 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 68 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(".Undefined;\r\n            return false;\r\n        }\r\n    }\r\n\r\n    /// <summary>\r\n  " +
                    "  /// Try to get a property value as the type matching the given pattern propert" +
                    "y ");
            
            #line default
            #line hidden
            
            #line 74 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Formatting.FormatLiteralOrNull(patternProperty.Pattern, true).Trim('"')));
            
            #line default
            #line hidden
            
            #line 74 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" as a <see cref=\"");
            
            #line default
            #line hidden
            
            #line 74 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 74 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(" AsPattern");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("(in JsonObjectProperty property)\r\n    {\r\n        return property.ValueAs<");
            
            #line default
            #line hidden
            
            #line 78 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 78 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(">();\r\n    }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(@"
    private static ImmutableDictionary<Regex, PatternPropertyValidator> CreatePatternPropertiesValidators()
    {
        ImmutableDictionary<Regex, PatternPropertyValidator>.Builder builder =
            ImmutableDictionary.CreateBuilder<Regex, PatternPropertyValidator>();

");
            
            #line default
            #line hidden
            
            #line 88 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  foreach (var patternProperty in PatternProperties)
    { 
            
            #line default
            #line hidden
            
            #line 90 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("        builder.Add(\r\n            PatternProperty");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(",__CorvusValidatePatternProperty");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(");\r\n");
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 93 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("\r\n        return builder.ToImmutable();\r\n    }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 97 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  foreach (var patternProperty in PatternProperties)
    { 
            
            #line default
            #line hidden
            
            #line 99 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("    private static ValidationContext __CorvusValidatePatternProperty");
            
            #line default
            #line hidden
            
            #line 99 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( PatternPropertySuffix(patternProperty) ));
            
            #line default
            #line hidden
            
            #line 99 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("(in JsonObjectProperty that, in ValidationContext validationContext, ValidationLe" +
                    "vel level)\r\n    {\r\n        return that.ValueAs<");
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( patternProperty.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write(">().Validate(validationContext, level);\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 103 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
  } 
            
            #line default
            #line hidden
            
            #line 104 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            
            #line 105 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.PatternProperties.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorPatternPropertiesBase {
        
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
