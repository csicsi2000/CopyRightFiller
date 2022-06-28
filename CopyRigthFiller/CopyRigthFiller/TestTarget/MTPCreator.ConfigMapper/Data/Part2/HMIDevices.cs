// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="HMIDevices.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Siemens.MTPCreator.Interfaces.ConfigHandler;
using System;
using System.Collections.Generic;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part2
{
    public class HMIDevices : IHMIDevices
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public HMIDevices() { }
        /// <summary>
        /// Construc
        /// </summary>
        /// <param name="name"></param>
        /// <param name="exportedScreens"></param>
        public HMIDevices(string name, IList<string> exportedScreens)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ExportedScreens = exportedScreens ?? throw new ArgumentNullException(nameof(exportedScreens));
        }
        /// <summary>
        /// Property representing the device name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// List representing the screens to export
        /// </summary>
        public IList<string> ExportedScreens { get; set; }

        /// <summary>
        /// If the HMI was set in the commandline, then it will be true and overwrite the configured HMI
        /// </summary>
        public bool Preferred { get; set; }
    }
}
