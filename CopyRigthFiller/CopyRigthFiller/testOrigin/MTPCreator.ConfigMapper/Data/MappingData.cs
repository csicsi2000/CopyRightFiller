// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="MappingData.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    /// <summary>
    /// Represents the configuration section "MappingData"
    /// </summary>
    public class MappingData : IMappingData
    {
        /// <summary>
        /// Contains the MTP mapping value pairs
        /// </summary>
        public Dictionary<string, string> ConfigValues { get; set; }
    }
}
