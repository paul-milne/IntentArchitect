﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.VisualStudio.Projects.Templates.ConsoleApp
{
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.VisualStudio.Projects\Templates\ConsoleApp\ConsoleAppTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ConsoleAppTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.VisualStudio.Projects\Templates\ConsoleApp\ConsoleAppTemplate.tt"




            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing Intent.CodeGen;\r\n");
            
            #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.VisualStudio.Projects\Templates\ConsoleApp\ConsoleAppTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly:DefaultIntentManaged(Mode.Ignore)]\r\n\r\nnamespace ");
            
            #line 24 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.VisualStudio.Projects\Templates\ConsoleApp\ConsoleAppTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    class Program
    {
        public Program()
        {
            
        }

        static void Main(string[] args)
        {
            var program = UnityConfig.GetConfiguredContainer().Resolve<Program>();
            program.Start();
        }

        public void Start()
        {
            Console.WriteLine(""Starting Application"");

            Console.ReadLine();
        }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
