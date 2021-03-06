﻿using Intent.MetaModel.Domain;
using Intent.Modules.Entities.Templates.DomainPartialEntity;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Intent.Modules.Entities.Templates.DomainEntity
{
    partial class DomainEntityTemplate : IntentRoslynProjectItemTemplateBase<IClass>, ITemplate, IHasDecorators<AbstractDomainEntityDecorator>
    {
        public const string Identifier = "Intent.Entities.Base";

        private IEnumerable<AbstractDomainEntityDecorator> _decorators;

        public DomainEntityTemplate(IClass model, IProject project)
            : base(Identifier, project, model)
        {
        }

        public override RoslynMergeConfig ConfigureRoslynMerger()
        {
            return new RoslynMergeConfig(new TemplateMetaData(Id, "1.0"));
        }

        protected override RoslynDefaultFileMetaData DefineRoslynDefaultFileMetaData()
        {
            var partialClass = Project.FindTemplateInstance(DomainPartialEntityTemplate.Identifier, Model);

            return new RoslynDefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: "${Model.Name}Partial",
                fileExtension: "cs",
                defaultLocationInProject: "Domain",
                className: "${Model.Name}",
                @namespace: "${Project.ProjectName}",
                dependsUpon: partialClass?.GetMetaData().FileNameWithExtension()
                );
        }

        public IEnumerable<AbstractDomainEntityDecorator> GetDecorators()
        {
            return _decorators ?? (_decorators = Project.ResolveDecorators(this));
        }

        public string GetBaseClass(IClass @class)
        {
            try
            {
                return GetDecorators().Select(x => x.GetBaseClass(@class)).SingleOrDefault(x => x != null) ?? @class.ParentClass?.Name ?? "Object";
            }
            catch (InvalidOperationException)
            {
                throw new Exception($"Multiple decorators attempting to modify 'base class' on {@class.Name}");
            }
        }

        public string GetInterfaces(IClass @class)
        {
            var interfaces = GetDecorators().SelectMany(x => x.GetInterfaces(@class)).Distinct().ToList();
            return interfaces.Any() ? ", " + interfaces.Aggregate((x, y) => x + ", " + y) : "";
        }

        public string ClassAnnotations(IClass @class)
        {
            return GetDecorators().Aggregate(x => x.ClassAnnotations(@class));
        }

        public string ConstructorAnnotations(IClass @class)
        {
            return GetDecorators().Aggregate(x => x.ConstructorAnnotations(@class));
        }

        public string ConstructorParameters(IClass @class)
        {
            return GetDecorators().Aggregate(x => x.ConstructorParameters(@class));
        }

        public string ConstructorBody(IClass @class)
        {
            return GetDecorators().Aggregate(x => x.ConstructorBody(@class));
        }

        public string ClassOtherConstructors(IClass @class)
        {
            return GetDecorators().Aggregate(x => x.ClassOtherConstructors(@class));
        }

        public string PropertyFieldAnnotations(IAttribute attribute)
        { 
            return GetDecorators().Aggregate(x => x.PropertyFieldAnnotations(attribute));
        }

        public string PropertyAnnotations(IAttribute attribute)
        {
            return GetDecorators().Aggregate(x => x.PropertyAnnotations(attribute));
        }

        public string PropertySetterBefore(IAttribute attribute)
        {
            return GetDecorators().Aggregate(x => x.PropertySetterBefore(attribute));
        }

        public string PropertySetterAfter(IAttribute attribute)
        {
            return GetDecorators().Aggregate(x => x.PropertySetterAfter(attribute));
        }

        public string PropertyAnnotations(IAssociationEnd associationEnd)
        {
            return GetDecorators().Aggregate(x => x.PropertyAnnotations(associationEnd));
        }

        public string PropertySetterBefore(IAssociationEnd associationEnd)
        {
            return GetDecorators().Aggregate(x => x.PropertySetterBefore(associationEnd));
        }

        public string PropertySetterAfter(IAssociationEnd associationEnd)
        {
            return GetDecorators().Aggregate(x => x.PropertySetterAfter(associationEnd));
        }
    }
}
