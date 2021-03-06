﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Auditing.Templates.ServiceBoundaryAudtingStrategy
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Auditing\Templates\ServiceBoundaryAudtingStrategy\ServiceBoundaryAuditingStrategyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ServiceBoundaryAuditingStrategyTemplate : IntentRoslynProjectItemTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\nusing System.Linq;\r\nusing Intent.Esb.Client.Publishing;\r\nusing Intent.Framewor" +
                    "k;\r\nusing Intent.Framework.EntityFramework.Auditing;\r\nusing Intent.Framework.Ent" +
                    "ityFramework.Auditing.Data;\r\nusing Intent.CodeGen;\r\n");
            
            #line 19 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Auditing\Templates\ServiceBoundaryAudtingStrategy\ServiceBoundaryAuditingStrategyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n[assembly:DefaultIntentManaged(Mode.Ignore)]\r\n\r\nnamespace ");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.Auditing\Templates\ServiceBoundaryAudtingStrategy\ServiceBoundaryAuditingStrategyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    public class ServiceBoundaryAuditingStrategy : IServiceBoundaryAuditingStrategy
    {
        private readonly IBusinessQueue _businessQueue;

        public ServiceBoundaryAuditingStrategy(IBusinessQueue businessQueue)
        {
            _businessQueue = businessQueue;
        }

        public void BeforeServiceCallHandler(ServiceCallAudit serviceCallAudit)
        {
        }

        public void AfterServiceCallHandler(ServiceCallAudit serviceCallAudit)
        {
        }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
