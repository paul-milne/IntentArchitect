﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Packages.HttpServiceProxy.Templates.AddressResolverInterface
{
    using Intent.SoftwareFactory.MetaModels.UMLModel;
    using Intent.MetaModel.UMLModel;
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
    
    #line 1 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.HttpServiceProxy\Templates\AddressResolverInterface\HttpServiceProxyAddressResolverInterfaceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class HttpServiceProxyAddressResolverInterfaceTemplate : IntentRoslynProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n\r\nusing System;\r\nusing Intent.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode" +
                    ".Fully)]\r\n\r\nnamespace ");
            
            #line 20 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.HttpServiceProxy\Templates\AddressResolverInterface\HttpServiceProxyAddressResolverInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public interface ");
            
            #line 22 "C:\Dev\Intent\Intent.SoftwareFactory\Intent.Packages.HttpServiceProxy\Templates\AddressResolverInterface\HttpServiceProxyAddressResolverInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        Uri Resolve(string targetApplicationName, string basePath);\r\n   " +
                    " }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
}