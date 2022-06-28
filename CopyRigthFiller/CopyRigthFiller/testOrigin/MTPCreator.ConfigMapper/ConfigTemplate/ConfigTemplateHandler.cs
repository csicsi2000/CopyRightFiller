// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="ConfigTemplateHandler.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using log4net;
using System;
using System.IO;
using System.Reflection;

namespace Siemens.MTPCreator.ConfigMapper.ConfigTemplate
{
    /// <summary>
    /// Handles config templates from the embedded resources
    /// </summary>
    public class ConfigTemplateHandler
    {
        private static readonly ILog _log4 = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private const string InsideFolder = @"UserFiles\MTPCreator\Config";
        private const string ProjectConfigName = "ProjectConfig.yaml";

        /// <summary>
        /// Gets the ProjectConfig template content
        /// </summary>
        public string GetProjectConfigTemplate()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Siemens.MTPCreator.ConfigMapper.ConfigTemplate.ProjectConfig.yaml";

            try
            {
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                _log4.Error(ex);
                return null;
            }
        }
    }
}
