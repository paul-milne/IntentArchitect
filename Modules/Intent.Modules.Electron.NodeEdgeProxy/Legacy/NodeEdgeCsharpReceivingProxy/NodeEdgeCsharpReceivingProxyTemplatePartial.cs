﻿using Intent.Modules.Application.Contracts.Templates.DTO;
using Intent.Modules.Application.Contracts.Templates.ServiceContract;
using Intent.Modules.Unity.Templates.UnityConfig;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.Service;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using System.Collections.Generic;
using System.Linq;
using ServiceModel = Intent.SoftwareFactory.MetaModels.Service.ServiceModel;

namespace Intent.Modules.Electron.NodeEdgeProxy.Legacy.NodeEdgeCsharpReceivingProxy
{
    partial class NodeEdgeCsharpReceivingProxyTemplate : IntentRoslynProjectItemTemplateBase<ServiceModel>, ITemplate, IHasTemplateDependencies, IHasNugetDependencies
    {
        public const string Identifier = "Intent.Electron.NodeEdgeProxy.CsharpReceivingProxy.Legacy";

        public NodeEdgeCsharpReceivingProxyTemplate(ServiceModel model, IProject project)
            : base(Identifier, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Identifier, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"{Model.Name}NodeEdgeProxy",
                fileExtension: "cs",
                defaultLocationInProject: @"NodeEdgeProxies\Generated",
                className: $"{Model.Name}NodeEdgeProxy",
                @namespace: "${Project.ProjectName}"
                );
        }

        public IEnumerable<ITemplateDependancy> GetTemplateDependencies()
        {
            return new[]
            {
                TemplateDependancy.OnTemplate(UnityConfigTemplate.Identifier),
                TemplateDependancy.OnModel(ServiceContractTemplate.Identifier, Model),
                TemplateDependancy.OnTemplate(DTOTemplate.Identifier)
            };
        }

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.NewtonsoftJson,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        private string GetMethodCallParameters(ServiceOperationModel o)
        {
            if (!o.Parameters.Any())
            {
                return "";
            }

            return o.Parameters.Select(x => $"payload.{x.Name.ToCamelCase()}").Aggregate((x, y) => x + ", " + y);
        }
    }
}
