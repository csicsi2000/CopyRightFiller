using CopyRigthFiller.Data;
using Interfaces.CopyRightFiller.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CopyRigthFiller.Logic
{
    public class GetFiles
    {
        Configs _configs;
        ILoggerManager _logger;

        public GetFiles(ILoggerManager logger,Configs config)
        {
            _configs = config;
            _logger = logger;
        }

        public List<string> GetAllFiles()
        {
            string[] files = Directory.GetFiles(_configs.SearchedFolder, _configs.Pattern, SearchOption.AllDirectories);
            List<string> allFiles = new List<string>();
            foreach(var file in files)
            {
                bool valid = true;
                foreach(var ignored in _configs.IgnoredFiles)
                {
                    if (file.Contains(ignored))
                    {
                        valid = false;
                    }
                }
                if (valid)
                {
                    allFiles.Add(file);
                }
            }

            return allFiles;
        }
    }
}
