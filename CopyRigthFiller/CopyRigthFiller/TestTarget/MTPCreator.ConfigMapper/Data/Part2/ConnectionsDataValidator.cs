// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="ConnectionsDataValidator.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using log4net;
using Siemens.MTPCreator.Interfaces.ConfigHandler.Part2;
using Siemens.MTPCreator.Interfaces.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part2
{
    /// <summary>
    /// Connection config validator
    /// </summary>
    class ConnectionsDataValidator
    {
        private static readonly ILog _log4 = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Validate connection config
        public void ValidateConnectionsData(IConnectionsData connectionDataConfig)
        {
            if(connectionDataConfig is null)
            {
                _log4.Debug(String.Format(Properties.Resource.LOG_IS_NULL, nameof(connectionDataConfig)));
                return;
            }

            ValidateList(connectionDataConfig.Connection, "Connection");
            ValidateList(connectionDataConfig.Pipe, "Pipe");
            ValidateList(connectionDataConfig.MeasurementLine, "MeasurementLine");
            ValidateList(connectionDataConfig.FunctionLine, "FunctionLine");
        }

        private void ValidateList<T>(IEnumerable<T> lista, string configName)
        {
            if(lista is null ||lista.Count() == 0)
            {
                _log4.Debug(String.Format(Properties.Resource.LOG_NO_FILTER_CONFIGURED, configName));
                return;
            }

            foreach(var item in lista)
            {
                if (String.IsNullOrEmpty(item.ToString()))
                {
                    throw new UserException(String.Format(Properties.Resource.LOG_EMPTY_CONFIG_STRING, configName));
                }
            }
        }
    }
}
