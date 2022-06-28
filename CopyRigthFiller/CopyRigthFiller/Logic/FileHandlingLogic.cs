// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="FileHandlingLogic.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using CopyRigthFiller.Data;
using Interfaces.CopyRightFiller.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CopyRigthFiller.Logic
{
    public class FileHandlingLogic
    {
        string[] templateLines = File.ReadLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Template.txt")).ToArray();
        Configs _config;
        ILoggerManager _logger;

        public FileHandlingLogic(ILoggerManager logger, Configs configs)
        {
            _logger = logger;
            _config = configs;
        }

        public void TryFixFiles(IEnumerable<string> files)
        {
            foreach (var filepath in files)
            {
                _logger.WriteLine("");

                string[] targetLines = File.ReadLines(filepath).Take(templateLines.Length).ToArray();

                if (CompareLines(templateLines, targetLines, Path.GetFileName(filepath)))
                {
                    _logger.WriteLine("Correct " + filepath);
                    continue;
                }

                if (!InsertTemplate(filepath))
                {
                    continue;
                }
            }
        }

        private List<string> DeleteWrongTemplate(List<string> lines)
        {
            if (String.IsNullOrEmpty(_config.DeleteLine))
            {
                return lines;
            }

            int count = 0;
            while (lines[0].StartsWith(_config.DeleteLine))
            {
                lines.RemoveAt(0);
                count++;
            }
            _logger.WriteLine(count + " lines were deleted.");
            return lines;
        }

        private bool CompareLines(string[] originalLines, string[] targetLines, string fileName)
        {
            for (int i = 0; i < originalLines.Length; i++)
            {
                if (string.Format(originalLines[i], fileName) != targetLines[i])
                {
                    return false;
                }
            }

            return true;
        }

        private bool InsertTemplate(string filePath)
        {
            var insertedLines = templateLines.Select(x => String.Format(x, Path.GetFileName(filePath))).ToList();
            insertedLines.Add("");
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();
                _logger.WriteLine("Template Inserted into " + filePath);
                lines = DeleteWrongTemplate(lines);
                lines.InsertRange(0, insertedLines);
                File.WriteAllLines(filePath, lines);

            }
            catch
            {
                _logger.WriteLine(filePath + " Insert failed");
                return false;
            }
            return true;
        }
    }
}
