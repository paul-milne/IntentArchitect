﻿using Intent.Modules.EntityFramework.Templates.RepositoryContract;
using Intent.Modules.RichDomain.Templates.EntityState;
using Intent.Modules.RichDomain.Templates.EntityStateInterface;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.UMLModel;
using Intent.SoftwareFactory.Templates;
using System.Collections.Generic;

namespace Intent.Modules.EntityFramework.Templates.Repository
{
    partial class RepositoryTemplate : IntentRoslynProjectItemTemplateBase<Class>, ITemplate, IHasTemplateDependencies
    {
        public const string Identifier = "Intent.EntityFramework.Repository";

        public RepositoryTemplate(Class model, IProject project)
            : base(Identifier, project, model)
        {
        }

        public IEnumerable<ITemplateDependancy> GetTemplateDependencies()
        {
            return new[]
            {
                TemplateDependancy.OnModel(DomainEntityStateTemplate.Identifier, Model),
                TemplateDependancy.OnModel(DomainEntityStateInterfaceTemplate.Identifier, Model),
                TemplateDependancy.OnModel(RepositoryContractTemplate.Identifier, Model)
            };
        }

        public string EntityInterfaceName => Project.FindTemplateInstance<IHasClassDetails>(DomainEntityStateInterfaceTemplate.Identifier, Model).ClassName;
        public string EntityName => Project.FindTemplateInstance<IHasClassDetails>(DomainEntityStateTemplate.Identifier, Model).ClassName;
        public string RepositoryContractName => Project.FindTemplateInstance<IHasClassDetails>(RepositoryContractTemplate.Identifier, Model).ClassName;

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"{Model.Name}Repository",
                fileExtension: "cs",
                defaultLocationInProject: "Repository",
                className: "${Name}Repository",
                @namespace: "${Project.Name}"
                );
        }
    }
}
