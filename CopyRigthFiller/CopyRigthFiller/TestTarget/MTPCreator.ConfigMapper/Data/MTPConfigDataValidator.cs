// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="MTPConfigDataValidator.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.ConfigMapper.Data.Part2;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    /// <summary>
    /// This class validates the MTPConfig
    /// </summary>
    public class MTPConfigDataValidator
    {
        // This method shoul validate all the requirements for the MTPConfig parts
        public void ValidateConfig(IMTPConfigData config)
        {
            ConnectionsDataValidator conValidate = new ConnectionsDataValidator();
            conValidate.ValidateConnectionsData(config.UnifiedObjects.Connections);
        }
    }
}
