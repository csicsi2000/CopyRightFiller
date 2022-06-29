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
using System.ComponentModel;
using System.IO;

namespace CopyRigthFiller
{
    class Program
    {
        static void Main(string[] args)
        {
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
                WriteOutConfigs(configurations, manager);
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

        public static void WriteOutConfigs(Configs config,ILoggerManager logger)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(config))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(config);
                if (value is IEnumerable<string>)
                {
                    logger.WriteLine(String.Format("{0}:", name));
                    foreach (var item in value as IEnumerable<string>)
                    {
                        logger.WriteLine(String.Format("\t{0}", item));
                    }
                }
                else
                {
                    logger.WriteLine(String.Format("{0} = {1}", name, value));
                }
            }
            logger.WriteLine(Environment.NewLine);
        }
    }
}
