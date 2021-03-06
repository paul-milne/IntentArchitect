﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.AngularJs.Auth.ImplicitAuth.Templates.SilentRenewCallbackView
{
    partial class SilentRenewCallbackViewTemplate : IntentProjectItemTemplateBase<object>, ITemplate
    {
        public const string Identifier = "Intent.AngularJs.Auth.ImplicitAuth.SilentRenewCallbackView";

        public SilentRenewCallbackViewTemplate(IProject project)
            : base (Identifier, project, null)
        {
        }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.OnceOff,
                codeGenType: CodeGenType.Basic,
                fileName: "SilentRenew",
                fileExtension: "html",
                defaultLocationInProject: @"wwwroot\App\Auth\RenewToken"
                );
        }
    }
}
