﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intent.SoftwareFactory.Templates
{
    public static class IFileMetaDataExtensions
    {
        public static string FileNameWithExtension(this IFileMetaData fm)
        {
            return $"{fm.FileName}.{fm.FileExtension}";
        }

        public static string GetFullLocationPathWithFileName(this IFileMetaData fm)
        {
            return $"{fm.GetFullLocationPath()}\\{fm.FileNameWithExtension()}";
        }

        public static string GetRelativeFilePathWithFileName(this IFileMetaData fm)
        {
            string relativePath = fm.GetRelativeFilePath();
            if (!string.IsNullOrWhiteSpace(relativePath))
            {
                return $"{relativePath}\\{fm.FileNameWithExtension()}";
            }
            return fm.FileNameWithExtension();
        }

    }

}
