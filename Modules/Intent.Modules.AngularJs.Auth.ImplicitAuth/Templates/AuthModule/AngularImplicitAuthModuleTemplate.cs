﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.AngularJs.Auth.ImplicitAuth.Templates.AuthModule
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
    
    #line 1 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\AuthModule\AngularImplicitAuthModuleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class AngularImplicitAuthModuleTemplate : IntentProjectItemTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(" \r\n");
            
            #line 13 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\AuthModule\AngularImplicitAuthModuleTemplate.tt"




            
            #line default
            #line hidden
            this.Write(@"namespace App.Auth {
    angular.module(""Auth"", [""LocalStorageModule""])
        .service(""OidcTokenManager"", [""Config"", (config: any) =>
            new OidcTokenManager({
                authority: config[""identity_authority_url""],
                client_id: """);
            
            #line 22 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\AuthModule\AngularImplicitAuthModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationName));
            
            #line default
            #line hidden
            this.Write("\",\r\n                redirect_uri: config[\"");
            
            #line 23 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\AuthModule\AngularImplicitAuthModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BasePathConfigKey));
            
            #line default
            #line hidden
            this.Write(@"""] + ""/#/login-callback/"",
                response_type: ""id_token token"",
                scope: ""openid profile email roles api"",
                persist: true,
                load_user_profile: true,
                silent_renew: true,
                silent_redirect_uri: config[""");
            
            #line 29 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\AuthModule\AngularImplicitAuthModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BasePathConfigKey));
            
            #line default
            #line hidden
            this.Write("\"] + \"/App/Auth/RenewToken/SilentRenew.html\"\r\n            })])\r\n        .config([" +
                    "\r\n            \"$stateProvider\", ($stateProvider: ng.ui.IStateProvider) => {\r\n   " +
                    "             $stateProvider\r\n                    .state(\"login-callback\", new Lo" +
                    "ginCallbackState())\r\n                    .state(\"login-redirect\", new LoginRedir" +
                    "ectState());\r\n            }\r\n        ])\r\n        .config([\r\n            \"$httpPr" +
                    "ovider\", ($httpProvider: ng.IHttpProvider) => {\r\n                $httpProvider.i" +
                    "nterceptors.push(\"AuthHttpInterceptorService\");\r\n            }\r\n        ])\r\n    " +
                    "    .run([\r\n            \"$rootScope\", \"$state\", \"OidcTokenManager\", \"localStorag" +
                    "eService\", ($rootScope: any, $state: ng.ui.IStateService, tokenManager: Oidc.Oid" +
                    "cTokenManager, localStorage: ng.local.storage.ILocalStorageService) => {\r\n      " +
                    "          $rootScope.$on(\"$stateChangeStart\", (event: any, toState: ng.ui.IState" +
                    ", toParams: any, fromState: ng.ui.IState, fromParams: any) => {\r\n               " +
                    "     var stateAllowsAnonymous = toState.data !== undefined ? toState.data.allowA" +
                    "nonymous : false;\r\n                    if (!stateAllowsAnonymous && tokenManager" +
                    ".expired) {\r\n                        localStorage.set(\"login-return-state\", toSt" +
                    "ate.name);\r\n                        localStorage.set(\"login-return-state-params\"" +
                    ", toParams);\r\n                        event.preventDefault();\r\n                 " +
                    "       $state.go(\"login-redirect\", {}, { reload: true });\r\n                    }" +
                    " else if (toState.name == \"login-redirect\") {\r\n                        if (!toke" +
                    "nManager.expired) {\r\n                            event.preventDefault();\r\n      " +
                    "                      location.href = location.origin;\r\n                        " +
                    "}\r\n                    }");
            
            #line 57 "C:\Dev\Intent\IntentArchitect\Modules\Intent.Modules.AngularJs.Auth.ImplicitAuth\Templates\AuthModule\AngularImplicitAuthModuleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AdditionalIfElses()));
            
            #line default
            #line hidden
            this.Write("\r\n                });\r\n            }\r\n        ]);\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
