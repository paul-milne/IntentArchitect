﻿using Intent.MetaModel.Common;
using Intent.MetaModel.Service;
using Intent.Modules.Application.Contracts;
using Intent.Modules.Application.Contracts.Templates.DTO;
using Intent.Modules.Application.Contracts.Templates.ServiceContract;
using Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceCallHandler;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.VisualStudio;
using System.Collections.Generic;
using System.Linq;

namespace Intent.Modules.Application.ServiceCallHandlers.Templates.ServiceImplementation
{
    partial class ServiceImplementationTemplate : IntentRoslynProjectItemTemplateBase<IServiceModel>, ITemplate, IHasTemplateDependencies, IHasNugetDependencies
    {
        public const string Identifier = "Intent.Application.ServiceCallHandlers.ServiceImplementation";
        public ServiceImplementationTemplate(IProject project, IServiceModel model)
            : base(Identifier, project, model)
        {
        }

        public IEnumerable<ITemplateDependancy> GetTemplateDependencies()
        {
            return new[]
            {
                TemplateDependancy.OnTemplate(DTOTemplate.Identifier),
                TemplateDependancy.OnTemplate(ServiceContractTemplate.Identifier),
            }
            .Union(Model.Operations.Select(x => TemplateDependancy.OnModel(ServiceCallHandlerImplementationTemplate.Identifier, x)).ToArray());
        }

        public override IEnumerable<INugetPackageInfo> GetNugetDependencies()
        {
            return new[]
            {
                NugetPackages.CommonServiceLocator,
                NugetPackages.Unity,
            }
            .Union(base.GetNugetDependencies())
            .ToArray();
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Name}",
                fileExtension: "cs",
                defaultLocationInProject: "ServiceImplementation",
                className: "${Name}",
                @namespace: "${Project.ProjectName}"

                );
        }

        private string GetOperationDefinitionParameters(IOperationModel o)
        {
            if (!o.Parameters.Any())
            {
                return "";
            }
            return o.Parameters.Select(x => $"{GetTypeName(x.TypeReference)} {x.Name}").Aggregate((x, y) => x + ", " + y);
        }

        private string GetOperationCallParameters(IOperationModel o)
        {
            if (!o.Parameters.Any())
            {
                return "";
            }
            return o.Parameters.Select(x => $"{x.Name}").Aggregate((x, y) => x + ", " + y);
        }

        private string GetOperationReturnType(IOperationModel o)
        {
            if (o.ReturnType == null)
            {
                return "void";
            }
            return GetTypeName(o.ReturnType.TypeReference);
        }

        public string GetServiceInterfaceName()
        {
            var serviceContractTemplate = Project.Application.FindTemplateInstance<IHasClassDetails>(TemplateDependancy.OnModel<ServiceModel>(ServiceContractTemplate.Identifier, x => x.Id == Model.Id));
            return NormalizeNamespace($"{serviceContractTemplate.Namespace}.{serviceContractTemplate.ClassName}");
        }

        private string GetHandlerClassName(IOperationModel o)
        {
            var serviceContractTemplate = Project.Application.FindTemplateInstance<IHasClassDetails>(TemplateDependancy.OnModel<OperationModel>(ServiceCallHandlerImplementationTemplate.Identifier, x => x.Id == o.Id));
            return NormalizeNamespace($"{serviceContractTemplate.Namespace}.{serviceContractTemplate.ClassName}");
        }

        private string GetTypeName(ITypeReference typeInfo)
        {
            var result = NormalizeNamespace(typeInfo.GetQualifiedName(this));
            if (typeInfo.IsCollection)
            {
                result = "List<" + result + ">";
            }
            return result;
        }
    }
}
