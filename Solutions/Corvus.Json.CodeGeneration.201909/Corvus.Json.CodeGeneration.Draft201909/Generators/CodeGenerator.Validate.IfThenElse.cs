//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft201909 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateIfThenElse : CodeGeneratorValidateIfThenElseBase {
        
        
        #line 156 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasIfThenElse;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"

    // This is only emitted if HasIfThenElse is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.IfThenElse should not be emitted if HasIfThenElse is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 23 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 25 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 26 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 29 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 29 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(@"
{
    private ValidationContext ValidateIfThenElse(in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationProperty(""if"");
        }

        ValidationContext ifResult = this.As<");
            
            #line default
            #line hidden
            
            #line 40 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfFullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 40 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(@">().Validate(validationContext.CreateChildContext(), level);

        if (!ifResult.IsValid)
        {
            if (level >= ValidationLevel.Verbose)
            {
                result = validationContext.MergeResults(false, level, ifResult, ifResult);
            }
        }
        else
        {
            if (level >= ValidationLevel.Verbose)
            {
                result = result.MergeChildContext(ifResult, true);
            }
            else
            {
                result = result.MergeChildContext(ifResult, false);
            }
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // if
        }
");
            
            #line default
            #line hidden
            
            #line 65 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
  if (HasThen)
    { 
            
            #line default
            #line hidden
            
            #line 67 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write("\r\n        if (ifResult.IsValid)\r\n        {\r\n            if (level > ValidationLev" +
                    "el.Basic)\r\n            {\r\n                result = result.PushValidationLocation" +
                    "Property(\"then\");\r\n            }\r\n\r\n            ValidationContext thenResult = t" +
                    "his.As<");
            
            #line default
            #line hidden
            
            #line 75 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ThenFullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 75 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(@">().Validate(validationContext.CreateChildContext(), level);

            if (!thenResult.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = validationContext.MergeResults(false, level, ifResult, thenResult).WithResult(isValid: false, ""Validation 9.2.2.2. then - failed to validate against the then schema."");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = validationContext.MergeResults(false, level, ifResult, thenResult).WithResult(isValid: false, ""Validation 9.2.2.2. then - failed to validate against the then schema."");
                }
                else
                {
                    result = validationContext.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeChildContext(thenResult, true);
                }

                result = result.MergeChildContext(thenResult, false);
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // then
            }
        }
");
            
            #line default
            #line hidden
            
            #line 107 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
  }
    if (HasElse)
    { 
            
            #line default
            #line hidden
            
            #line 110 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write("\r\n        if (!ifResult.IsValid)\r\n        {\r\n            if (level > ValidationLe" +
                    "vel.Basic)\r\n            {\r\n                result = result.PushValidationLocatio" +
                    "nProperty(\"else\");\r\n            }\r\n\r\n            ValidationContext elseResult = " +
                    "this.As<");
            
            #line default
            #line hidden
            
            #line 118 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ElseFullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 118 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write(@">().Validate(validationContext.CreateChildContext(), level);

            if (!elseResult.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = validationContext.MergeResults(false, level, ifResult, elseResult).WithResult(isValid: false, ""Validation 9.2.2.3. else - failed to validate against the else schema."");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = validationContext.MergeResults(false, level, ifResult, elseResult).WithResult(isValid: false, ""Validation 9.2.2.2. else - failed to validate against the else schema."");
                }
                else
                {
                    result = validationContext.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeChildContext(elseResult, true);
                }

                result = result.MergeChildContext(elseResult, false);
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // else
            }
        }
");
            
            #line default
            #line hidden
            
            #line 150 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
  } 
            
            #line default
            #line hidden
            
            #line 151 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
            this.Write("\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 155 "C:\Users\matth\source\repos\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.IfThenElse.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateIfThenElseBase {
        
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
