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
            _logger.WriteLine("Searched folder: " + _configs.SearchedFolder);
            string[] files = Directory.GetFiles(_configs.SearchedFolder, _configs.Pattern, SearchOption.AllDirectories);
            List<string> allFiles = new List<string>();
            foreach(var file in files)
            {
                var filterRes = _configs.IgnoredFiles.FirstOrDefault(x => file.Contains(x));

                if(filterRes != null)
                {
                    _logger.WriteLine(file.Replace(_configs.SearchedFolder,"") + " was ignored.");
                    continue;
                }

                allFiles.Add(file);
            }

            return allFiles;
        }
    }
}
