﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.Contracts.Mappings.Templates.Mapping
{
    using Intent.MetaModel.DTO;
    using Intent.SoftwareFactory.Templates;
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class MappingTemplate : Intent.SoftwareFactory.Templates.IntentRoslynProjectItemTemplateBase<IDTOModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\n");
            
            #line 14 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Runtime.Ser" +
                    "ialization;\r\nusing AutoMapper;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n" +
                    "\r\nnamespace ");
            
            #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public static class ");
            
            #line 24 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" \r\n    {\r\n\t\tpublic static ");
            
            #line 26 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContractTypeName));
            
            #line default
            #line hidden
            this.Write(" MapTo");
            
            #line 26 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContractTypeName));
            
            #line default
            #line hidden
            this.Write(" (this ");
            
            #line 26 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DomainTypeName));
            
            #line default
            #line hidden
            this.Write(" projectFrom)\r\n\t\t{\r\n\t\t\treturn Mapper.Map<");
            
            #line 28 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContractTypeName));
            
            #line default
            #line hidden
            this.Write(">(projectFrom);\r\n\t\t}\t\t\r\n\r\n\t\tpublic static List<");
            
            #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContractTypeName));
            
            #line default
            #line hidden
            this.Write("> MapTo");
            
            #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContractTypeName));
            
            #line default
            #line hidden
            this.Write("s (this IEnumerable<");
            
            #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DomainTypeName));
            
            #line default
            #line hidden
            this.Write("> projectFrom)\r\n\t\t{\r\n\t\t\treturn projectFrom.Select(x => x.MapTo");
            
            #line 33 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\Mapping\MappingTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ContractTypeName));
            
            #line default
            #line hidden
            this.Write("()).ToList();\r\n\t\t}\r\n\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
