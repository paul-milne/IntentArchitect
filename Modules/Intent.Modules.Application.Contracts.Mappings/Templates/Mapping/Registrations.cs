﻿using Intent.MetaModel.DTO;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Intent.Modules.Application.Contracts.Mappings.Templates.Mapping
{
    [Description("Intent Applications Contract Mapping Extentions Template")]
    public class Registrations : ModelTemplateRegistrationBase<IDTOModel>
    {

        private IMetaDataManager _metaDataManager;


        public Registrations(IMetaDataManager metaDataManager)
        {
            _metaDataManager = metaDataManager;
            
            FilterExpression = "!string.IsNullOrWhiteSpace(model.MappedClassId)";
        }

        public override string TemplateId
        {
            get
            {
                return MappingTemplate.Identifier;
            }
        }

        public override ITemplate CreateTemplateInstance(IProject project, IDTOModel model)
        {
            return new MappingTemplate(project, model);
        }

        public override IEnumerable<IDTOModel> GetModels(IApplication application)
        {
            return _metaDataManager.GetDTOModels(application);
        }
    }
}
