﻿using Intent.MetaModel.Dto.Old;
using Intent.MetaModel.Hosting;
using Intent.Modules.AngularJs.ServiceAgent.Templates.DTO;
using Intent.Modules.AngularJs.ServiceAgent.Templates.Proxy;
using Intent.SoftwareFactory;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.Service;
using Intent.SoftwareFactory.Registrations;
using System.Linq;

namespace Intent.Modules.AngularJs.ServiceAgent
{
    public class Registrations : OldProjectTemplateRegistration
    {
        public Registrations()
        {
        }

        public override void RegisterStuff(IApplication application, IMetaDataManager metaDataManager)
        {
            var clientServiceModels = metaDataManager.GetMetaData<ServiceModel>(new MetaDataType("Service-Legacy")).Where(x => x.Clients.Contains(application.ApplicationName)).ToList();
            var clientDtoModels = metaDataManager.GetMetaData<DtoModel>(new MetaDataType("DtoProjection")).Where(x => x.Clients.Contains(application.ApplicationName)).ToList();
            var hostingConfig = metaDataManager.GetMetaData<HostingConfigModel>("LocalHosting").SingleOrDefault(x => x.ApplicationName == application.ApplicationName);

            foreach (var serviceModel in clientServiceModels)
            {
                if (serviceModel.DistributionMode == ServiceDistributionMode.WebApi)
                {
                    RegisterTemplate(TypescriptWebApiClientServiceProxyTemplate.Identifier, project => new TypescriptWebApiClientServiceProxyTemplate(serviceModel, hostingConfig, project, application.EventDispatcher));
                }
            }

            foreach (var model in clientDtoModels)
            {
                RegisterTemplate(TypescriptDtoTemplate.Identifier, project => new TypescriptDtoTemplate(model, project));
            }
        }
    }
}
