//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft7 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateFormat : CodeGeneratorValidateFormatBase {
        
        
        #line 197 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasFormat;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"

    // This is only emitted if HasFormat is true
    if(!HasFormat)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.Format should not be emitted if HasFormat is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using System.Text.Json;
using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 24 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 24 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 26 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 27 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 30 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 30 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("\r\n{\r\n    private ValidationContext ValidateFormat(JsonValueKind valueKind, in Val" +
                    "idationContext result, ValidationLevel level)\r\n    {\r\n        if (valueKind != J" +
                    "sonValueKind.String)\r\n        {\r\n            return result;\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  if (IsJsonRelativePointer)
    { 
            
            #line default
            #line hidden
            
            #line 40 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeRelativePointer(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 41 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonDate)
    { 
            
            #line default
            #line hidden
            
            #line 44 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeDate(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 45 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonDateTime)
    { 
            
            #line default
            #line hidden
            
            #line 48 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeDateTime(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 49 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonDuration)
    { 
            
            #line default
            #line hidden
            
            #line 52 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeDuration(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonTime)
    { 
            
            #line default
            #line hidden
            
            #line 56 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeTime(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 57 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonEmail)
    { 
            
            #line default
            #line hidden
            
            #line 60 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeEmail(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 61 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonHostname)
    { 
            
            #line default
            #line hidden
            
            #line 64 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeHostname(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 65 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonIdnEmail)
    { 
            
            #line default
            #line hidden
            
            #line 68 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeIdnEmail(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 69 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonIdnHostname)
    { 
            
            #line default
            #line hidden
            
            #line 72 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeIdnHostName(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 73 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToByte == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 76 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeByte(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 77 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToSByte == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 80 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeSByte(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 81 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToInt16 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 84 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeInt16(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 85 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToUInt16 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 88 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUInt16(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 89 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToInt32 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 92 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeInt32(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 93 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToUInt32 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 96 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUInt32(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 97 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToInt64 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 100 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeInt64(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 101 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToUInt64 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 104 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUInt64(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 105 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToInt128 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 108 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeInt128(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 109 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToUInt128 == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 112 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUInt128(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 113 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToHalf == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 116 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeHalf(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 117 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToSingle == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 120 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeSingle(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 121 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToDouble == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 124 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeDouble(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 125 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (ConversionOperatorToDecimal == "implicit")
    { 
            
            #line default
            #line hidden
            
            #line 128 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeDecimal(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 129 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonInteger)
    { 
            
            #line default
            #line hidden
            
            #line 132 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeInteger(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 133 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonIpV4)
    { 
            
            #line default
            #line hidden
            
            #line 136 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeIpV4(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 137 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonIpV6)
    { 
            
            #line default
            #line hidden
            
            #line 140 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeIpV6(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 141 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonIri)
    { 
            
            #line default
            #line hidden
            
            #line 144 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeIri(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 145 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonIriReference)
    { 
            
            #line default
            #line hidden
            
            #line 148 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeIriReference(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 149 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonPointer)
    { 
            
            #line default
            #line hidden
            
            #line 152 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypePointer(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 153 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonRegex)
    { 
            
            #line default
            #line hidden
            
            #line 156 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeRegex(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 157 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonTime)
    { 
            
            #line default
            #line hidden
            
            #line 160 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeTime(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 161 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonUri)
    { 
            
            #line default
            #line hidden
            
            #line 164 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUri(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 165 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonUriReference)
    { 
            
            #line default
            #line hidden
            
            #line 168 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUriReference(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 169 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonUriTemplate)
    { 
            
            #line default
            #line hidden
            
            #line 172 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUriTemplate(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 173 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonBase64Content)
    { 
            
            #line default
            #line hidden
            
            #line 176 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeBase64Content(this, result, level, false)" +
                    ";\r\n");
            
            #line default
            #line hidden
            
            #line 177 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonBase64String)
    { 
            
            #line default
            #line hidden
            
            #line 180 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeBase64String(this, result, level, false);" +
                    "\r\n");
            
            #line default
            #line hidden
            
            #line 181 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonContent)
    { 
            
            #line default
            #line hidden
            
            #line 184 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeContent(this, result, level, false);\r\n");
            
            #line default
            #line hidden
            
            #line 185 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else if (IsJsonUuid)
    { 
            
            #line default
            #line hidden
            
            #line 188 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return Corvus.Json.Validate.TypeUuid(this, result, level);\r\n");
            
            #line default
            #line hidden
            
            #line 189 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  }
    else
    { 
            
            #line default
            #line hidden
            
            #line 192 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("        return result;\r\n");
            
            #line default
            #line hidden
            
            #line 193 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
  } 
            
            #line default
            #line hidden
            
            #line 194 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
            this.Write("    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 196 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.7\Corvus.Json.CodeGeneration.Draft7\Templates\CodeGenerator.Validate.Format.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateFormatBase {
        
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
