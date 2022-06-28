// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="AppSettings.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.IO;
using Siemens.MTPCreator.Interfaces._Interfaces.ConfigHandler.Data;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    public class AppSettings : IAppSettings
    {
        /// <summary>
        /// Developer log path
        /// </summary>
        public FileInfo ReportFile { get; set; }

        /// <summary>
        /// TiaData JSON file path
        /// </summary>
        public FileInfo TiaDataFile { get ; set; }

        /// <summary>
        /// Folder path for the temporary generated TIA files
        /// </summary>
        public DirectoryInfo TempFolder { get; set; }

        /// <summary>
        /// ExportMode
        /// </summary>
        public IExportMode ExportMode { get; set; }

        /// <summary>
        /// PartailMatch mappings
        /// </summary>
        public bool PartailMatch { get; set; }

        /// <summary>
        /// TiaPortal Version
        /// </summary>
        public string TiaPortalVersion { get; set; }
    }
}
