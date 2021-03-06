﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Application.Contracts.Mappings.Templates.MappingProfile
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class MappingProfileTemplate : Intent.SoftwareFactory.Templates.IntentRoslynProjectItemTemplateBase<IList<IDTOModel>>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\n");
            
            #line 14 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\nusing System.Runtime.Serialization;\r\nusing AutoMapper;\r\n\r\n[assembly: DefaultInt" +
                    "entManaged(Mode.Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class ");
            
            #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : Profile\r\n    {\r\n\t\r\n        protected override void  Configure()\r\n        {\t\t\r\n" +
                    "\t\t\t//using the default() to help the compiler to understand the overloading\t\r\n");
            
            #line 28 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
 foreach (var model in Model) {
            
            #line default
            #line hidden
            this.Write("\t\t\tConfigure(this, default(");
            
            #line 29 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDomainType(model)));
            
            #line default
            #line hidden
            this.Write("), default(");
            
            #line 29 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetContractType(model)));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 30 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\t\r\n");
            
            #line 34 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
 foreach (var model in Model) {
            
            #line default
            #line hidden
            this.Write("\t    public static IMappingExpression<");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDomainType(model)));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetContractType(model)));
            
            #line default
            #line hidden
            this.Write("> Configure(IProfileExpression cfg, ");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDomainType(model)));
            
            #line default
            #line hidden
            this.Write(" sourceType, ");
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetContractType(model)));
            
            #line default
            #line hidden
            this.Write(" destinationType)\r\n\t\t{\r\n            return cfg.CreateMap<");
            
            #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDomainType(model)));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetContractType(model)));
            
            #line default
            #line hidden
            this.Write(">()\r\n                //.IncludeBase<>()\r\n");
            
            #line 39 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
foreach (var field in model.Fields){
	if (field.Mapping != null && field.Name != field.Mapping.Path){

            
            #line default
            #line hidden
            this.Write("                .ForMember(dest => dest.");
            
            #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name.ToPascalCase()));
            
            #line default
            #line hidden
            this.Write(", opt => opt.MapFrom(src => src.");
            
            #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ToPascalCasePath(field.Mapping.Path)));
            
            #line default
            #line hidden
            this.Write("))\r\n");
            
            #line 43 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
	}
            
            #line default
            #line hidden
            
            #line 44 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("                ;\r\n\t\t}\r\n");
            
            #line 47 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Application.Contracts.Mappings\Templates\MappingProfile\MappingProfileTemplate.tt"
}//foreach 
            
            #line default
            #line hidden
            this.Write("\r\n\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
