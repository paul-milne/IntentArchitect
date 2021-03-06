﻿using Intent.Modules.CommonTypes.Contracts;
using Intent.SoftwareFactory.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intent.Modules.CommonTypes.TypeResolvers
{
    [Description("Java Type Resolver")]
    public class JavaTypeResolverFactory : ITypeResolverFactory
    {
        public string Name
        {
            get
            {
                return "Java";
            }
        }

        public int Priotiry
        {
            get
            {
                return 0;
            }
        }

        public IEnumerable<string> SupportedFileTypes
        {
            get
            {
                return new[] { "java" };
            }
        }

        public ITypeResolver Create()
        {
            return new JavaTypeResolver();
        }

    }
}
