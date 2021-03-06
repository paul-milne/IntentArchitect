﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.UserContext.Templates.UserContextStatic
{
    partial class UserContextStaticTemplate : IntentRoslynProjectItemTemplateBase<object>, ITemplate
    {
        public const string Identifier = "Intent.UserContext.UserContextStatic";

        public UserContextStaticTemplate(IProject project)
            : base (Identifier, project, null)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                       overwriteBehaviour: OverwriteBehaviour.Always,
                       fileName: $"UserContext",
                       fileExtension: "cs",
                       defaultLocationInProject: "Context"
                );
        }
    }
}
