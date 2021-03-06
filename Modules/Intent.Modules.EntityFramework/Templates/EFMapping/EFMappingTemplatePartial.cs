﻿using Intent.Modules.RichDomain.Templates.EntityState;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.UMLModel;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using System.Collections.Generic;
using System.Linq;

namespace Intent.Modules.EntityFramework.Templates.EFMapping
{
    partial class EFMappingTemplate : IntentRoslynProjectItemTemplateBase<Class>, ITemplate, IHasTemplateDependencies, IHasNugetDependencies, IHasDecorators<IEFMappingTemplateDecorator>
    {
        public const string Identifier = "Intent.EntityFramework.EFMapping";
        private IEnumerable<IEFMappingTemplateDecorator> _decorators;

        public EFMappingTemplate(Class model, IProject project)
            : base (Identifier, project, model)
        {
        }

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.EntityFramework,
                NugetPackages.IntentFrameworkDomain,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        public IEnumerable<ITemplateDependancy> GetTemplateDependencies()
        {
            return new[]
            {
                TemplateDependancy.OnModel(DomainEntityStateTemplate.Identifier, Model),
            };
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"{Model.Name}Mapping",
                fileExtension: "cs",
                defaultLocationInProject: "Generated\\EFMapping",
                className: $"{Model.Name}Mapping",
                @namespace: "${Project.Name}");
        }

        public IEnumerable<IEFMappingTemplateDecorator> GetDecorators()
        {
            return _decorators ?? (_decorators = Project.ResolveDecorators(this));
        }

        public string PropertyMappings(Class @class)
        {
            return GetDecorators().Aggregate(x => x.PropertyMappings(@class));
        }
    }

    public interface IEFMappingTemplateDecorator : ITemplateDecorator
    {
        string[] PropertyMappings(Class @class);
    }
}
