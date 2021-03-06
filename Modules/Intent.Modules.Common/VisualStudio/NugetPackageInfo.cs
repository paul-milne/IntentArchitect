﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Intent.SoftwareFactory.VisualStudio
{
    public class NugetPackageInfo : INugetPackageInfo
    {
        public NugetPackageInfo(string name, string version, string targetFramework)
        {
            Name = name;
            Version = version;
            TargetFramework = targetFramework;
            AssemblyRedirects = new List<AssemblyRedirectInfo>();
        }

        public string Name { get; }
        public string Version { get; }
        public string TargetFramework { get; }
        public IList<AssemblyRedirectInfo> AssemblyRedirects { get; }
        public bool CanAddFile(string file)
        {
            switch (_addFileBlacklistBehaviour)
            {
                case AddFileBlacklistBehaviour.All:
                    return false;
                case AddFileBlacklistBehaviour.None:
                    return true;
                case AddFileBlacklistBehaviour.AllExcept:
                    return !_blacklistFileEntries.Any(x => x.Equals(file, StringComparison.OrdinalIgnoreCase));
                case AddFileBlacklistBehaviour.Only:
                    return _blacklistFileEntries.Any(x => x.Equals(file, StringComparison.OrdinalIgnoreCase));
                default:
                    throw new ArgumentOutOfRangeException(nameof(file));
            }
        }

        public NugetPackageInfo WithAssemblyRedirect(AssemblyRedirectInfo assemblyRedirect)
        {
            AssemblyRedirects.Add(assemblyRedirect);
            return this;
        }

        /// <summary>
        /// By default, all files allowed to be added.
        /// </summary>
        public NugetPackageInfo BlockAddingOfAllFiles()
        {
            _addFileBlacklistBehaviour = AddFileBlacklistBehaviour.All;
            _blacklistFileEntries = new string[0];
            return this;
        }

        /// <summary>
        /// By default, all files allowed to be added.
        /// </summary>
        public NugetPackageInfo AllowAddingOfAllFiles()
        {
            _addFileBlacklistBehaviour = AddFileBlacklistBehaviour.None;
            _blacklistFileEntries = new string[0];
            return this;
        }

        /// <summary>
        /// By default, all files allowed to be added.
        /// </summary>
        public NugetPackageInfo BlockAddingOfAllFilesExcept(IEnumerable<string> files)
        {
            _addFileBlacklistBehaviour = AddFileBlacklistBehaviour.Only;
            _blacklistFileEntries = files.ToArray();
            return this;
        }

        /// <summary>
        /// By default, all files allowed to be added.
        /// </summary>
        public NugetPackageInfo AllowAddingOfAllFilesExcept(IEnumerable<string> files)
        {
            _addFileBlacklistBehaviour = AddFileBlacklistBehaviour.AllExcept;
            _blacklistFileEntries = files.ToArray();
            return this;
        }

        private AddFileBlacklistBehaviour _addFileBlacklistBehaviour = AddFileBlacklistBehaviour.None;
        private string[] _blacklistFileEntries = new string[0];

        private enum AddFileBlacklistBehaviour
        {
            All = 0,
            None = 1,
            AllExcept = 2,
            Only = 3,
        }
    }
}
