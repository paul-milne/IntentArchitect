﻿using Intent.MetaModel.Dto.Old;
using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.MetaModels.Class;
using Intent.SoftwareFactory.MetaModels.Common;
using Intent.SoftwareFactory.Templates;

namespace Intent.Modules.AngularJs.ServiceAgent.Templates.DTO
{
    partial class TypescriptDtoTemplate : IntentProjectItemTemplateBase<ClassModel>, ITemplate
    {
        public const string Identifier = "Intent.AngularJs.ServiceAgent.DTO";

        public TypescriptDtoTemplate(DtoModel model, IProject project)
            : base(Identifier, project, model.Class)
        {
            Namespace = model.BoundedContextName == project.ApplicationName().Replace("_Client", "") ? "App.Contracts" : $"App.Contracts.{model.BoundedContextName}";
            Location = model.BoundedContextName == project.ApplicationName().Replace("_Client", "") ? $@"wwwroot\App\DTOs\Generated" : $@"wwwroot\App\DTOs\Generated\{model.BoundedContextName}";
        }

        public string Namespace { get; }
        public string Location { get; }

        public override DefaultFileMetaData DefineDefaultFileMetaData()
        {
            return new DefaultFileMetaData(
                overwriteBehaviour: OverwriteBehaviour.Always,
                codeGenType: CodeGenType.Basic,
                fileName: Model.ClassType.TypeName,
                fileExtension: "ts",
                defaultLocationInProject: Location);
        }
    }

    public static class TypescriptExtensions
    {
        public static string ConvertType(this TypeModel typeModel)
        {
            var propertyType = typeModel.FullName;

            if (typeModel.IsEnum)
            {
                if (typeModel.IsGenericType)
                    propertyType = ConvertType(typeModel.GenericArguments[0]);
                else
                    propertyType = typeModel.TypeName.Replace("?", "");
            }

            if (typeModel.IsGenericType && (typeModel.TypeName.Contains("List") || typeModel.TypeName.Contains("IEnumerable") || typeModel.TypeName.Contains("[]")))
            {
                propertyType = ConvertType(typeModel.GenericArguments[0]) + "[]";
            }
            if (typeModel.IsGenericType && typeModel.TypeName.Contains("Nullable"))
            {
                propertyType = ConvertType(typeModel.GenericArguments[0]);
            }
            else if (typeModel.IsGenericType && typeModel.TypeName.Contains("Dictionary"))
            {
                propertyType = "any[]";
            }
            else
            {
                if (propertyType.IndexOf("Contracts") != -1)
                {
                    propertyType = propertyType.Substring(propertyType.IndexOf("Contracts"));
                    return propertyType;
                }
            }

            switch (propertyType)
            {
                case "byte[]":
                case "Byte[]":
                case "System.Byte[]":
                    propertyType = "Array<number>";
                    break;
                case "DateTime":
                case "DateTime?":
                case "System.DateTime":
                case "System.DateTime?":
                case "System.Nullable<System.DateTime>":
                    propertyType = "Date";
                    break;
                case "string":
                case "String":
                case "System.String":
                case "Guid":
                case "Guid?":
                case "System.Guid":
                case "System.Guid?":
                case "System.Nullable<System.Guid>":
                    propertyType = "string";
                    break;
                case "int":
                case "Int32":
                case "Int32?":
                case "System.Int32":
                case "System.Int32?":
                case "System.Nullable<System.Int32>":
                case "decimal":
                case "Decimal":
                case "Decimal?":
                case "System.Decimal":
                case "System.Decimal?":
                case "System.Nullable<System.Decimal>":
                case "System.TimeSpan":
                case "System.TimeSpan?":
                case "System.Nullable<System.TimeSpan>":
                    propertyType = "number";
                    break;
                case "bool":
                case "Boolean":
                case "System.Boolean":
                case "System.Boolean?":
                case "System.Nullable<System.Boolean>":
                    propertyType = "boolean";
                    break;
                case "object":
                case "Object":
                case "System.Object":
                    propertyType = "any";
                    break;
                default:
                    break;
            }

            return propertyType;
        }
    }
}
