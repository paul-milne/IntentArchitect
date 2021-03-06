﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.VisualStudio.Projects.Templates.NuGetPackagesConfig
{
    public partial class NuGetPackagesConfigTemplate : IntentProjectItemTemplateBase<object>, ITemplate
    {
        public NuGetPackagesConfigTemplate(IProject project)
            : base (CoreTemplateId.NuGetPackagesConfig, project, null)
        {
        }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.OnceOff,
                codeGenType: CodeGenType.Basic,
                fileName: "packages",
                fileExtension: "config",
                defaultLocationInProject: "");
        }
    }
}
