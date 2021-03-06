﻿using Intent.SoftwareFactory.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intent.SoftwareFactory.Templates
{
    public class RoslynDefaultFileMetaData : DefaultFileMetaData
    {
        [Obsolete("use the one with namespace and classname ans specify them, upgrade template to bind to ClassName and Namespace")]
        public RoslynDefaultFileMetaData(
                    OverwriteBehaviour overwriteBehaviour,
                    string fileName,
                    string fileExtension,
                    string defaultLocationInProject
                    )
            : this(overwriteBehaviour, fileName, fileExtension, defaultLocationInProject, null, null, null)
        {
            this.CustomMetaData["Namespace"] = "${Project.ProjectName}";
        }

        public RoslynDefaultFileMetaData(
                    OverwriteBehaviour overwriteBehaviour,
                    string fileName,
                    string fileExtension,
                    string defaultLocationInProject,
                    string className,
                    string @namespace,
                    string dependsUpon = null
                    )
            : base(overwriteBehaviour, Templates.CodeGenType.RoslynWeave, fileName, fileExtension, defaultLocationInProject)
        {
            if (!string.IsNullOrWhiteSpace(className))
            {
                this.CustomMetaData["ClassName"] = className;
            }
            if (!string.IsNullOrWhiteSpace(@namespace))
            {
                this.CustomMetaData["Namespace"] = @namespace;
            }
            if (!string.IsNullOrWhiteSpace(dependsUpon))
            {
                this.CustomMetaData["Depends On"] = dependsUpon;
                /*
                if (!string.IsNullOrWhiteSpace(defaultLocationInProject))
                {
                    this.CustomMetaData["Depends On"] = defaultLocationInProject + "\\" + dependsUpon;
                }
                else
                {
                    this.CustomMetaData["Depends On"] = dependsUpon;
                }*/
            }
        }
    }
}
