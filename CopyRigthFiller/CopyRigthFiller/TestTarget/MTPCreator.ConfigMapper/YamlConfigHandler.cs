// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="YamlConfigHandler.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.ConfigMapper.Data;
using Siemens.MTPCreator.ConfigMapper.Yaml.Interfaces;
using Siemens.MTPCreator.Interfaces.ConfigHandler;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;
using System;
using System.Collections.Generic;
using System.IO;

namespace Siemens.MTPCreator.ConfigMapper
{
    /// <summary>
    /// Handles all the yaml conversion to our own data sctructure 
    /// </summary>
    public class YamlConfigHandler : IMTPConfigHandler
    {
        const string _mTPConfigFileName = "MTPConfig.yaml";
        const string _projectConfigFileName = "ProjectConfig.yaml";

        private DirectoryInfo m_ConfigFolder { get; set; }

        private IList<IMTPYamlDataHandler> m_YamlMTPDataHandlers { get; set; }

        private IList<IProjectYamlDataHandler> m_YamlProjectDataHandlers { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configDir"></param>
        public YamlConfigHandler(DirectoryInfo configDir, IList<IMTPYamlDataHandler> mTPYamlDataHandlers, IList<IProjectYamlDataHandler> projectYamlDataHandlers)
        {
            m_ConfigFolder = configDir;
            m_YamlMTPDataHandlers = mTPYamlDataHandlers;
            m_YamlProjectDataHandlers = projectYamlDataHandlers;
        }

        /// <summary>
        /// Returns an object representing every section in the config file
        /// </summary>
        /// <returns></returns>
        public IMTPConfigData GetConfigData()
        {
            string mTPcontents = File.ReadAllText(GetConfigFile(_mTPConfigFileName));
            string projectContent = File.ReadAllText(GetConfigFile(_projectConfigFileName));

            IMTPConfigData configData = GetConfigDataFromString(mTPcontents, projectContent);

            MTPConfigDataValidator validator = new MTPConfigDataValidator();
            validator.ValidateConfig(configData);

            return configData;
        }

        internal string GetConfigFile(string configName)
        {
            string configFile = Path.Combine(m_ConfigFolder.FullName, configName);
            string creatorEnvVar = Environment.GetEnvironmentVariable("MTPCREATOR");
            if (!string.IsNullOrEmpty(creatorEnvVar))
            {
                return CheckIfConfigExists(creatorEnvVar, configName);
            }
            else
            {
                return CheckIfConfigExists(m_ConfigFolder.FullName, configName);
            }
        }

        internal string CheckIfConfigExists(string folderPath, string configName)
        {
            string configFile = Path.Combine(folderPath,configName);

            if (File.Exists(configFile))
            {
                return configFile;
            }
            else
            {
                throw new InvalidOperationException(Properties.Resource.LOG_NO_MTP_CONFIG);
            }
        }

        internal IMTPConfigData GetConfigDataFromString(string mTPConfigContent, string projectConfigContent)
        {
            _ = mTPConfigContent ?? throw new ArgumentNullException(nameof(mTPConfigContent));
            _ = projectConfigContent ?? throw new ArgumentNullException(nameof(projectConfigContent));


            MTPConfigData configData = new MTPConfigData();

            var mappingMTP = Yaml.YamlMapping.FromYaml(mTPConfigContent);
            foreach (var handler in m_YamlMTPDataHandlers)
            {
                handler.YamlToConfigData(mappingMTP.MTPConfig, configData);
            }

            var mappingProject = Yaml.YamlMapping.FromYaml(projectConfigContent);
            foreach (var handler in m_YamlProjectDataHandlers)
            {
                handler.YamlToConfigData(mappingProject.ProjectConfig, configData);
            }

            return configData;
        }
    }
}
