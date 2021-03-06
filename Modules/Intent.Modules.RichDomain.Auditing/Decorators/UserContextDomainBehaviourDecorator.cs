using Intent.MetaModel.UMLModel;
using Intent.Modules.RichDomain.Templates.EntityBehaviour;
using Intent.SoftwareFactory.MetaModels.UMLModel;

namespace Intent.Modules.RichDomain.Auditing.Decorators
{
    public class UserContextDomainBehaviourDecorator : IDomainBehaviourDecorator
    {
        public const string Identifier = "Intent.RichDomain.Auditing.DomainBehaviour";
        public string OperationStart(Class model)
        {
            if (model.IsAggregateRoot())
            {
                return @"
            UpdateDateTime = DateTime.UtcNow;
            UpdatedBy = UserContext.Current.UserName;";
            }
            return null;
        }
    }
}