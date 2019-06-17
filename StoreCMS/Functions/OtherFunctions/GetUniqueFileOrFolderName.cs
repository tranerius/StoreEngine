﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Treynessen.Functions
{
    public static partial class OtherFunctions
    {
        public static string GetUniqueFileOrFolderName(string path, string fileName, string fileExtension = null)
        {
            string[] filesOrFolders = null;
            try
            {
                if (!string.IsNullOrEmpty(fileExtension))
                    filesOrFolders = Directory.GetFiles(path, $"*{fileExtension}");
                else
                    filesOrFolders = Directory.GetDirectories(path);
            }
            catch (DirectoryNotFoundException) { }
            if (filesOrFolders == null || filesOrFolders.Length == 0)
                return $"{fileName}{fileExtension}";
            bool has = true;
            int index = 0;
            while (has)
            {
                has = false;
                if (index == int.MaxValue)
                {
                    fileName += index.ToString();
                    index = 0;
                }
                string current = $"{path}{fileName}{(index == 0 ? string.Empty : $"{index.ToString()}")}{fileExtension}";
                foreach (var f in filesOrFolders)
                {
                    if (f.Equals(current, StringComparison.InvariantCultureIgnoreCase))
                    {
                        has = true;
                        break;
                    }
                }
                if (index == 0 && has)
                {
                    fileName = $"{GetNameWithUnderscore(fileName)}";
                }
                if (!has)
                {
                    if (index > 0)
                        fileName += $"{index.ToString()}";
                    fileName += fileExtension;
                }
                ++index;
            }
            return fileName;
        }
    }
}