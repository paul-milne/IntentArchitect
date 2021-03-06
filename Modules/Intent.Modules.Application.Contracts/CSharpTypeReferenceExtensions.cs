using Intent.MetaModel.Common;
using Intent.MetaModel.DTO;
using Intent.Modules.Application.Contracts.Templates.DTO;
using Intent.Modules.Constants;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaData;
using Intent.SoftwareFactory.Templates;
using System.Linq;

namespace Intent.Modules.Application.Contracts
{
    public static class CSharpTypeReferenceExtensions
    {
        public static string GetQualifiedName(this ITypeReference typeInfo, IProjectItemTemplate template, string templateIdentifier = DTOTemplate.Identifier)
        {
            var result = typeInfo.Name;
            if (typeInfo.Type == ReferenceType.ClassType)
            {
                var templateInstance = template.Project.Application.FindTemplateInstance<IHasClassDetails>(TemplateDependancy.OnModel<DTOModel>(templateIdentifier, x => x.Id == typeInfo.Id));
                if (templateInstance != null)
                {
                    result = $"{templateInstance.Namespace}.{templateInstance.ClassName}";
                }
            }
            else if (typeInfo.Stereotypes.Any(x => x.Name == StandardStereotypes.CSharpType))
            {
                result = typeInfo.Stereotypes.GetPropertyValue<string>(StandardStereotypes.CSharpType, "TypeName");
            }
            else if (typeInfo.GetPropertyValue<string>(StandardStereotypes.NamespaceProvider, "Namespace") != null)
            {
                result = $"{typeInfo.GetPropertyValue<string>(StandardStereotypes.NamespaceProvider, "Namespace")}.{typeInfo.Name}";
            }
            else if (typeInfo.Folder?.GetPropertyValue<string>(StandardStereotypes.NamespaceProvider, "Namespace") != null)
            {
                result = $"{typeInfo.Folder.GetPropertyValue<string>(StandardStereotypes.NamespaceProvider, "Namespace")}.{typeInfo.Name}";
            }

            if (typeInfo.IsNullable && (typeInfo.Type == ReferenceType.Enum || (typeInfo.Type == ReferenceType.DataType && typeInfo.Stereotypes.GetPropertyValue(StandardStereotypes.CSharpType, "IsPrimitive", false))))
            {
                result += "?";
            }

            return result;
        }
    }
}