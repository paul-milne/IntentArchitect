﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Intent.MetaModel.DTO;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Templates;
using Intent.SoftwareFactory.Templates.Registrations;

namespace Intent.Modules.AngularJs.Templates.State
{
    [Description("Intent - AngularJs State Registration")]
    public class AngularJsStateRegistration : ModelTemplateRegistrationBase<ViewStateModel>
    {
        private readonly IMetaDataManager _metaDataManager;

        public AngularJsStateRegistration(IMetaDataManager metaDataManager)
        {
            _metaDataManager = metaDataManager;
        }

        public override string TemplateId => AngularJsStateTemplate.Identifier;

        public override ITemplate CreateTemplateInstance(IProject project, ViewStateModel model)
        {
            return new AngularJsStateTemplate(project, model);
        }

        public override IEnumerable<ViewStateModel> GetModels(IApplication application)
        {
            return _metaDataManager.GetMetaData<ViewStateModel>(new MetaDataType("ViewState")).Where(x => x.Application.Name == application.ApplicationName).ToList();
        }
    }
}

