﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AspNet.WebApi.Legacy.Controller
{
    using Intent.SoftwareFactory.MetaModels.Class;
    using Intent.SoftwareFactory.MetaModels.Service;
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class WebApiControllerTemplate : IntentRoslynProjectItemTemplateBase<ServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            this.Write(" \r\n");
            
            #line 16 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"


            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\nusing System.Linq;\r\nusing System.Collections.Generic;\r\nusing Sys" +
                    "tem.Transactions;\r\nusing System.Web;\r\nusing System.Web.Http;\r\n");
            
            #line 25 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 
    if (Model.Operations.Any(x => x.UsesRawSignature))
    {

            
            #line default
            #line hidden
            this.Write("using System.IO;\r\nusing System.Net;\r\nusing System.Net.Http;\r\n");
            
            #line 32 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 
    }

            
            #line default
            #line hidden
            
            #line 35 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DependencyUsings));
            
            #line default
            #line hidden
            this.Write("\r\nusing Intent.CodeGen;\r\n\r\n[assembly: DefaultIntentManaged(Mode.Fully)]\r\n\r\nnamesp" +
                    "ace ");
            
            #line 40 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(".Controllers\r\n{\r\n    [Authorize]\r\n    [RoutePrefix(\"api/");
            
            #line 43 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name.Replace("Service", "").ToLower()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n    public class ");
            
            #line 44 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Controller : ApiController\r\n    {\r\n        private readonly I");
            
            #line 46 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(" _appService;");
            
            #line 46 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DeclarePrivateVariables()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n        public ");
            
            #line 48 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Controller (I");
            
            #line 48 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(" appService");
            
            #line 48 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorParams()));
            
            #line default
            #line hidden
            this.Write("\r\n            )\r\n        {\r\n            if (appService == null)\r\n                " +
                    "throw new ArgumentNullException(\"appService\");\r\n            _appService = appSer" +
                    "vice;");
            
            #line 53 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ConstructorInit()));
            
            #line default
            #line hidden
            this.Write("\r\n        } \r\n    \r\n");
            
            #line 56 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
    foreach (var operation in Model.Operations)
    {
        //Transactions
        string isolationLevel = "ReadCommitted"; // TODO: Make configurable
        
        //NOTE: The following are hook points which can be overriden to custom actions in your plugins:
        Action getMethodDefinitionParameters = () => GetMethodDefinitionParameters(operation, false);
        Action getMethodCallParameters = () => GetMethodCallParameters(operation, false, operation.UsesRawSignature ? string.Empty : "payload.");
        Action getReturnType = () => 
            
            #line default
            #line hidden
            
            #line 64 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetMethodReturnType(operation)));
            
            #line default
            #line hidden
            
            #line 64 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
;
        Action adaptServiceResult = () => 
            
            #line default
            #line hidden
            this.Write("appServiceResult");
            
            #line 65 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
;
        Action additionalParameters = () => {};

        if (!operation.UsesRawSignature)
        {
            
            
            #line default
            #line hidden
            this.Write("        public class ");
            
            #line 71 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Payload\r\n        {\r\n");
            
            #line 73 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

            foreach (var parameter in operation.Parameters)
            {
                foreach (var decorator in PayloadPropertyDecorators(parameter))
                {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 79 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decorator));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 80 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

                }

            
            #line default
            #line hidden
            this.Write("            public ");
            
            #line 83 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Type.FullName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 83 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 84 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 89 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        
        }

        if (!operation.Security.RequiresAuthentication) {

            
            #line default
            #line hidden
            this.Write("        [AllowAnonymous]\r\n");
            
            #line 95 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        }

            
            #line default
            #line hidden
            this.Write("        [AcceptVerbs(\"POST\")]\r\n        [Route(\"");
            
            #line 98 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 99 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        
        if (operation.Security.RequiredRoles.Any()) {

            
            #line default
            #line hidden
            this.Write("        [Authorize(Roles = \"");
            
            #line 102 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Security.RequiredRoles.First()));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 103 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        }

        var methodDefinitionParameters = operation.UsesRawSignature
            ? operation.Parameters.Select(p => p.Type.FullName + " " + p.Name).Aggregate((x, y) => x + ", " + y)
            : operation.Name + "Payload payload";

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 109 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 getReturnType(); 
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 109 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 109 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(methodDefinitionParameters));
            
            #line default
            #line hidden
            this.Write(")\r\n        {");
            
            #line 110 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeginOperation(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 112 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        if (operation.HasReturnType())
        {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 114 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 getReturnType(); 
            
            #line default
            #line hidden
            this.Write(" result = default(");
            
            #line 114 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 getReturnType(); 
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 115 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
      }
            
            #line default
            #line hidden
            this.Write("            TransactionOptions tso = new TransactionOptions();\r\n            tso.I" +
                    "solationLevel = IsolationLevel.");
            
            #line 117 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(isolationLevel));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 118 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
	if (operation.TransactionOptions.TimeoutInSeconds != null)
    { 
            
            #line default
            #line hidden
            this.Write("\t\t\ttso.Timeout = TimeSpan.FromSeconds(");
            
            #line 120 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.TransactionOptions.TimeoutInSeconds));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 121 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\r\n            try\r\n            {");
            
            #line 124 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeTransaction(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n                using (TransactionScope ts = new TransactionScope(TransactionSc" +
                    "opeOption.Required, tso))\r\n                {");
            
            #line 126 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BeforeCallToAppLayer(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 127 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

        if (operation.HasReturnType())
        {

            
            #line default
            #line hidden
            this.Write("                    var appServiceResult = _appService.");
            
            #line 130 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 130 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 getMethodCallParameters(); 
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 131 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

            if (ReturnsHttpResponseMessage(operation))
            {

            
            #line default
            #line hidden
            this.Write("                    result = Request.CreateResponse(HttpStatusCode.OK);\r\n        " +
                    "            result.Content = ");
            
            #line 136 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetHttpResponseMessageContent(operation)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 137 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("                    result = ");
            
            #line 142 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 adaptServiceResult(); 
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 143 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"

            }
        }
        else
        {

            
            #line default
            #line hidden
            this.Write("                        _appService.");
            
            #line 148 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 148 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
 getMethodCallParameters(); 
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 149 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        }

            
            #line default
            #line hidden
            
            #line 150 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AfterCallToAppLayer(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n                    ts.Complete();\r\n                }");
            
            #line 152 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AfterTransaction(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n            catch (Exception e) \r\n            {");
            
            #line 155 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(OnExceptionCaught(operation)));
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n\r\n");
            
            #line 158 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
        if (operation.HasReturnType())
        {

            
            #line default
            #line hidden
            this.Write("            return result;\r\n");
            
            #line 161 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
      }
            
            #line default
            #line hidden
            this.Write("\r\n        }\r\n\r\n");
            
            #line 165 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
    }

        // Source code of base class: http://aspnetwebstack.codeplex.com/SourceControl/latest#src/System.Web.Http/ApiController.cs
        // As dispose is not virtual, looking at the source code, this looks like a better hook in point

            
            #line default
            #line hidden
            this.Write("        protected override void Dispose(bool disposing)\r\n        {\r\n            b" +
                    "ase.Dispose(disposing);\r\n\r\n            //dispose all resources\r\n            _app" +
                    "Service.Dispose();\r\n        }\r\n");
            
            #line 177 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\WebApiControllerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassMethods()));
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 2 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

void GetMethodDefinitionParameters(ServiceOperationModel o) 
{
	GetMethodDefinitionParameters(o, false);
}

void GetMethodDefinitionParameters(ServiceOperationModel o, bool withLeadingComma) 
{
	GetMethodDefinitionParameters(o.Parameters, withLeadingComma);
}

void GetMethodDefinitionParameters(List<ParameterModel> parameters, bool withLeadingComma) 
{
	    for(int i = 0; i < parameters.Count; i++) 
	{ 
		ParameterModel p = parameters[i];
		if (withLeadingComma || (!withLeadingComma && i != 0))
        {
			
        
        #line default
        #line hidden
        
        #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 20 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

        } 
	
        
        #line default
        #line hidden
        
        #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Type.FullName));

        
        #line default
        #line hidden
        
        #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(" ");

        
        #line default
        #line hidden
        
        #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));

        
        #line default
        #line hidden
        
        #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

	}	
}


        
        #line default
        #line hidden
        
        #line 28 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"


void GetMethodCallParameters(ServiceOperationModel o) 
{
	GetMethodCallParameters(o, false);
}

void GetMethodCallParameters(ServiceOperationModel o, bool withLeadingComma) 
{
	GetMethodCallParameters(o.Parameters, withLeadingComma);
}

void GetMethodCallParameters(List<ParameterModel> parameters, bool withLeadingComma)
{
    for(int i = 0; i < parameters.Count; i++) 
	{ 
		ParameterModel p = parameters[i];
		if (withLeadingComma || (!withLeadingComma && i != 0))
        {
			
        
        #line default
        #line hidden
        
        #line 47 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 47 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

        } 
	
        
        #line default
        #line hidden
        
        #line 49 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));

        
        #line default
        #line hidden
        
        #line 49 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

	}

}

void GetMethodCallParameters(ServiceOperationModel o, bool withLeadingComma, string prefix)
{
	List<ParameterModel> parameters = o.Parameters;

    for(int i = 0; i < parameters.Count; i++) 
	{ 
		ParameterModel p = parameters[i];
		if (withLeadingComma || (!withLeadingComma && i != 0))
        {
			
        
        #line default
        #line hidden
        
        #line 63 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(", ");

        
        #line default
        #line hidden
        
        #line 63 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

        } 

        
        #line default
        #line hidden
        
        #line 65 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"
this.Write(this.ToStringHelper.ToStringWithCulture(prefix + p.Name));

        
        #line default
        #line hidden
        
        #line 65 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AspNet.WebApi\Legacy\Controller\./../Services.ttinclude"

	}
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
