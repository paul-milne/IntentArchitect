﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.UMLModel;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using System.Collections.Generic;

namespace Intent.Modules.RichDomain.Templates.Enum
{

    partial class DomainEnumTemplate : IntentProjectItemTemplateBase<EnumDefinition>, ITemplate, IHasNugetDependencies
    {
        public const string Identifier = "Intent.RichDomain.Enum";

        public DomainEnumTemplate(EnumDefinition model, IProject project)
            : base (Identifier, project, model)
        {
        }

        public string Namespace
        {
            get
            {
                return Project.Name;
            }
        }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.OnceOff,
                codeGenType: CodeGenType.Basic,
                fileName: $"{Model.Type}",
                fileExtension: "cs",
                defaultLocationInProject: "Types"
                );
        }

        public IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.IntentFrameworkDomain,
            };
        }
    }
}
