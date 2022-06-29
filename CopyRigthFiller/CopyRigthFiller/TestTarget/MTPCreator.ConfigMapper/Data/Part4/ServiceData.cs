// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="ServiceData.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.IO;
using Siemens.MTPCreator.Interfaces.ServiceParser.Data;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part4
{
    class ServiceJsonFileData : IServiceJsonFileData
    {
        public ServiceJsonFileData(FileInfo filePath, IList<IServiceDeviceData> serviceDeviceData)
        {
            FilePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            ServiceDeviceData = serviceDeviceData ?? throw new ArgumentNullException(nameof(serviceDeviceData));
        }

        public FileInfo FilePath { get; }

        public IList<IServiceDeviceData> ServiceDeviceData { get; }
    }

    public class ParamConfig : IConfigurationData
    {
        public string ConfigurationType { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }
    }

    class ServiceDeviceData : IServiceDeviceData
    {
        public ServiceDeviceData(string plcName, IList<IServiceData> serviceData, IList<IConfigurationData> configurationParamsData, IList<IConfigurationData> mTPProcedureParameters, IList<IConfigurationData> mTPProcessValueInputs, IList<IConfigurationData> mTPProcessValueOutputs, IList<IConfigurationData> mTPReportValues)
        {
            PlcName = plcName;
            ServiceData = serviceData;
            ConfigurationParamsData = configurationParamsData;
            MTPProcedureParameters = mTPProcedureParameters;
            MTPProcessValueInputs = mTPProcessValueInputs;
            MTPProcessValueOutputs = mTPProcessValueOutputs;
            MTPReportValues = mTPReportValues;
        }

        public string PlcName { get; }
        public IList<IServiceData> ServiceData { get; }
        public IList<IConfigurationData> ConfigurationParamsData { get; set; }
        public IList<IConfigurationData> MTPProcedureParameters { get; set; }
        public IList<IConfigurationData> MTPProcessValueInputs { get; set; }
        public IList<IConfigurationData> MTPProcessValueOutputs { get; set; }
        public IList<IConfigurationData> MTPReportValues { get; set; }
    }

    class ServiceData : IServiceData
    {
        public ServiceData(string plcName, string serviceName, string recipeDataBlockName, IList<IMTPControlModules> mTPControlModules, IList<IMTPSteps> mTPSteps, IList<IMTPProcedures> mTPProcedures)
        {
            PlcName = plcName ?? throw new ArgumentNullException(nameof(plcName));
            ServiceName = serviceName ?? throw new ArgumentNullException(nameof(serviceName));
            RecipeDataBlockName = recipeDataBlockName ?? throw new ArgumentNullException(nameof(recipeDataBlockName));
            MTPControlModules = mTPControlModules ?? throw new ArgumentNullException(nameof(mTPControlModules));
            MTPSteps = mTPSteps ?? throw new ArgumentNullException(nameof(mTPSteps));
            MTPProcedures = mTPProcedures ?? throw new ArgumentNullException(nameof(mTPProcedures));
        }

        public string PlcName { get; }

        public string ServiceName { get; }

        public string RecipeDataBlockName { get; }

        public IList<IMTPControlModules> MTPControlModules { get; }

        public IList<IMTPSteps> MTPSteps { get; }

        public IList<IMTPProcedures> MTPProcedures { get; }
    }

    class MTPControlModules : IMTPControlModules
    {
        public MTPControlModules(string mtpControlModuleName, int mtpControlModuleIndex)
        {
            MtpControlModuleName = mtpControlModuleName ?? throw new ArgumentNullException(nameof(mtpControlModuleName));
            MtpControlModuleIndex = mtpControlModuleIndex;
        }

        public string MtpControlModuleName { get; }

        public int MtpControlModuleIndex { get; }
    }

    class MTPSteps : IMTPSteps
    {
        public MTPSteps(string mtpStepName, int mtpStepIndex)
        {
            MtpStepName = mtpStepName ?? throw new ArgumentNullException(nameof(mtpStepName));
            MtpStepIndex = mtpStepIndex;
        }

        public string MtpStepName { get; }

        public int MtpStepIndex { get; }
    }

    class MTPProcedures : IMTPProcedures
    {
        public MTPProcedures(string name, int id, string description, int paramStartIndex, int paramEndIndex)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Id = id;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            ParamStartIndex = paramStartIndex;
            ParamEndIndex = paramEndIndex;
        }

        public string Name { get; }

        public int Id { get; }

        public string Description { get; }

        public int ParamStartIndex { get; }

        public int ParamEndIndex { get; }
    }


}
