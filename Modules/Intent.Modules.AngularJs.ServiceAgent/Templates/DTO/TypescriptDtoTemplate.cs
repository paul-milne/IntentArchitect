﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AngularJs.ServiceAgent.Templates.DTO
{
    using Intent.SoftwareFactory.MetaModels.Common;
    using Intent.SoftwareFactory.MetaModels.Class;
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class TypescriptDtoTemplate : IntentProjectItemTemplateBase<ClassModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nnamespace ");
            
            #line 16 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 18 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
 AddClass(Model);
            
            #line default
            #line hidden
            this.Write("} \r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 21 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"

    void AddClass(ClassModel model)
    {

        
        #line default
        #line hidden
        
        #line 24 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("    export interface ");

        
        #line default
        #line hidden
        
        #line 25 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(model.ClassType.TypeName));

        
        #line default
        #line hidden
        
        #line 25 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("\r\n    {\r\n");

        
        #line default
        #line hidden
        
        #line 27 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
        foreach (var p in model.Properties)
        {
            
        

        
        #line default
        #line hidden
        
        #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("        ");

        
        #line default
        #line hidden
        
        #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Name.ToCamelCase()));

        
        #line default
        #line hidden
        
        #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(": ");

        
        #line default
        #line hidden
        
        #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Type.ConvertType()));

        
        #line default
        #line hidden
        
        #line 31 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 32 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
 
        }

        
        #line default
        #line hidden
        
        #line 34 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
this.Write("    }\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 37 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
        foreach (var child in model.ChildClasses)
        {
            AddClass(child);
        }

        
        #line default
        #line hidden
        
        #line 42 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"

    }

        
        #line default
        #line hidden
        
        #line 45 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.ServiceAgent\Templates\DTO\TypescriptDtoTemplate.tt"
 



        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
