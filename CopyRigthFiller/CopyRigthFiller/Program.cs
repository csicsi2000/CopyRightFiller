// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="Program.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using CopyRigthFiller.Data;
using CopyRigthFiller.Logger;
using CopyRigthFiller.Logic;
using Interfaces.CopyRightFiller.Logger;
using Interfaces.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;

namespace CopyRigthFiller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Configs configurations = JsonParser.GetConfig();
            List<ILogger> loggers = new List<ILogger>()
            {
                new ConsoleLogger(),
                new FileLogger(configurations.LogFilepath)
            };
            ILoggerManager manager = new LoggerManager(loggers);

            try
            {
                manager.WriteLine("Tool started");
                GetFiles files = new GetFiles(manager, configurations);
                var allFiles = files.GetAllFiles();

                FileHandlingLogic logic = new FileHandlingLogic(manager, configurations);
                logic.TryFixFiles(allFiles);
            }
            catch(UserException ex)
            {
                manager.WriteLine(ex.ToString());
            }
            catch(Exception ex)
            {
                manager.WriteLine(ex.ToString());
            }
        }
    }
}
