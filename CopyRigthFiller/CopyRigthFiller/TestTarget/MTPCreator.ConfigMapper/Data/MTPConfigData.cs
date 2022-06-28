// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="MTPConfigData.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Siemens.MTPCreator.ConfigMapper.Yaml;
using Siemens.MTPCreator.Interfaces.ConfigHandler;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Part2;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Part4;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    /// <summary>
    /// Contains all the configuration sections
    /// </summary>
    public class MTPConfigData : IMTPConfigData
    {
        /// <summary>
        /// Class representing overall configuration data
        /// </summary>

        public MTPConfigData()
        {

        }

        public MTPConfigData(IMappingData mapping, IAppSettings appSettings, IConstantValues constantValues, IMTPFileConfig mtpFileConfig,  IServiceInfrastructure serviceInfo)
        {
            Mapping = mapping ?? throw new ArgumentNullException(nameof(mapping));
            AppSettings = appSettings ?? throw new ArgumentNullException(nameof(appSettings));
            ConstantValues = constantValues ?? throw new ArgumentNullException(nameof(constantValues));
            MTPFileConfig = mtpFileConfig ?? throw new ArgumentNullException(nameof(mtpFileConfig));
            Infrastructure = serviceInfo ?? throw new ArgumentNullException(nameof(serviceInfo));
        }

        public MTPConfigData(IMappingData mapping, IAppSettings appSettings, IConstantValues constantValues, IMTPFileConfig mtpFileConfig,  IServiceInfrastructure serviceInfo,  IUnifiedObjectsData unifiedObjects) : this(mapping, appSettings, constantValues, mtpFileConfig,  serviceInfo)
        {
            UnifiedObjects = unifiedObjects;
        }

        /// <summary>
        /// Field for representing MappingData
        /// </summary>
        public IMappingData Mapping { get; set; }

        /// <summary>
        /// Field for representing AppSettings
        /// </summary>
        public IAppSettings AppSettings { get; set; }

        /// <summary>
        /// Field for representing ConstantValues
        /// </summary>
        public IConstantValues ConstantValues { get; set; }

        /// <summary>
        /// Field for representing MTPFileConfig
        /// </summary>
        public IMTPFileConfig MTPFileConfig { get; set; }

        /// <summary>
        /// Infrastructure
        /// </summary>
        public IServiceInfrastructure Infrastructure { get; set; }

        /// <summary>
        /// Hmi Devices
        /// </summary>
        public IList<IHMIDevices> HMIDevices { get; set; }

        /// <summary>
        /// UnifiedObjects filter
        /// </summary>
        public IUnifiedObjectsData UnifiedObjects { get; set; }
    }
}
