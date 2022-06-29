// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="MTPFileConfig.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    /// <summary>
    /// Class implementation of the MTPFileConfig configuration section
    /// </summary>
    public class MTPFileConfig :  IMTPFileConfig
    {

        /// <summary>
        /// 
        /// </summary>
        public string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ToolID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ToolVendor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ToolUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ToolRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ToolVersion { get; set; }

    }

}

