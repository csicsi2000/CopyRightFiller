// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="MTPJsonData.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Siemens.MTPCreator.ConfigMapper.Data.Part4
{
    /// <summary>
    /// Special class generated from a json file trough built-in tools
    /// </summary>
    public class Rootobject
    {
        public string ProjectGuid { get; set; }
        public string FileVersion { get; set; }
        public string TiaPortalVersion { get; set; }
        public Mtpdevice[] MtpDevices { get; set; }
    }

    public class Mtpdevice
    {
        public string DeviceGuid { get; set; }
        public string PlcName { get; set; }
        public Mtpconfigurationparameters MtpConfigurationParameters { get; set; }
        public Mtpprocedureparameters MtpProcedureParameters { get; set; }
        public Mtpprocessvaluesinput MtpProcessValuesInput { get; set; }
        public Mtpprocessvaluesoutput MtpProcessValuesOutput { get; set; }
        public Mtpreportvalues MtpReportValues { get; set; }
        public Mtpservice[] MtpServices { get; set; }
    }

    public class Mtpconfigurationparameters
    {
        public Mtpconfigurationparameterselement[] MtpConfigurationParametersAnalog { get; set; }
        public Mtpconfigurationparameterselement[] MtpConfigurationParametersDigital { get; set; }       
        public Mtpconfigurationparameterselement[] MtpConfigurationParametersBinary { get; set; }
        public Mtpconfigurationparameterselement[] MtpConfigurationParametersString { get; set; }
    }

    public class Mtpconfigurationparameterselement
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocedureparameters
    {
        public Mtpprocedureparameterselement[] MtpProcedureParametersAnalog { get; set; }
        public Mtpprocedureparameterselement[] MtpProcedureParametersDigital { get; set; }
        public Mtpprocedureparameterselement[] MtpProcedureParametersBinary { get; set; }
        public Mtpprocedureparameterselement[] MtpProcedureParametersString { get; set; }
    }

    public class Mtpprocedureparameterselement
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }


    public class Mtpprocessvaluesinput
    {
        public Mtpprocessvaluesinputanalog[] MtpProcessValuesInputAnalog { get; set; }
        public Mtpprocessvaluesinputdigital[] MtpProcessValuesInputDigital { get; set; }
        public Mtpprocessvaluesinputbinary[] MtpProcessValuesInputBinary { get; set; }
        public Mtpprocessvaluesinputstring[] MtpProcessValuesInputString { get; set; }
    }

    public class Mtpprocessvaluesinputanalog
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesinputdigital
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesinputbinary
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesinputstring
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesoutput
    {
        public Mtpprocessvaluesoutputanalog[] MtpProcessValuesOutputAnalog { get; set; }
        public Mtpprocessvaluesoutputdigital[] MtpProcessValuesOutputDigital { get; set; }
        public Mtpprocessvaluesoutputbinary[] MtpProcessValuesOutputBinary { get; set; }
        public Mtpprocessvaluesoutputstring[] MtpProcessValuesOutputString { get; set; }
    }

    public class Mtpprocessvaluesoutputanalog
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesoutputdigital
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesoutputbinary
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpprocessvaluesoutputstring
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpreportvalues
    {
        public Mtpreportvaluesanalog[] MtpReportValuesAnalog { get; set; }
        public Mtpreportvaluesdigital[] MtpReportValuesDigital { get; set; }
        public Mtpreportvaluesbinary[] MtpReportValuesBinary { get; set; }
        public Mtpreportvaluesstring[] MtpReportValuesString { get; set; }
    }

    public class Mtpreportvaluesanalog
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpreportvaluesdigital
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpreportvaluesbinary
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpreportvaluesstring
    {
        public string MtpParameterName { get; set; }
        public int MtpParameterIndex { get; set; }
    }

    public class Mtpservice
    {
        public string ServiceGuid { get; set; }
        public string ServiceName { get; set; }
        public string RecipeDataBlockName { get; set; }
        public Mtpcontrolmodule[] MtpControlModules { get; set; }
        public Mtpstep[] MtpSteps { get; set; }
        public Mtpprocedure[] MtpProcedures { get; set; }
    }

    public class Mtpcontrolmodule
    {
        public string MtpControlModuleName { get; set; }
        public int MtpControlModuleIndex { get; set; }
    }

    public class Mtpstep
    {
        public string MtpStepName { get; set; }
        public int MtpStepIndex { get; set; }
    }

    public class Mtpprocedure
    {
        public string ProcedureGuid { get; set; }
        public string ProcedureName { get; set; }
        public int ProcedureId { get; set; }
        public string ProcedureDescription { get; set; }
        public int ParameterStartIndex { get; set; }
        public int ParameterEndIndex { get; set; }
        public Mtptransitstate[] MtpTransitStates { get; set; }
    }

    public class Mtptransitstate
    {
        public string TransitStateGuid { get; set; }
        public string TransitStateName { get; set; }
        public int TransitStateId { get; set; }
        public string TransitStateDescription { get; set; }
    }

}

