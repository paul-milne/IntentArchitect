﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intent.Modules.CommonTypes
{
    public class TypeResolverFactoryRepository : Contracts.ITypeResolverFactoryRepository
    {
        private IEnumerable<Contracts.ITypeResolverFactory> _typeResolvers;
        private NoResolverRegisteredTypeResolverFactory _noTypeResolverResolver = new NoResolverRegisteredTypeResolverFactory();

        public TypeResolverFactoryRepository(Contracts.ITypeResolverFactory[] typeResolvers)
        {
            _typeResolvers = typeResolvers;
        }

        public IEnumerable<Contracts.ITypeResolverFactory> TypeResolvers
        {
            get
            {
                return _typeResolvers;
            }
        }

        public Contracts.ITypeResolverFactory GetTypeResolver(SoftwareFactory.Templates.IFileMetaData metaData)
        {
            var resolver = _typeResolvers.OrderByDescending(tr => tr.Priotiry).FirstOrDefault(tr => tr.SupportedFileTypes.Any( ft => ft.ToLower().EndsWith( metaData.FileExtension.ToLower())) );

            return resolver ?? _noTypeResolverResolver;
        }
    }
}
