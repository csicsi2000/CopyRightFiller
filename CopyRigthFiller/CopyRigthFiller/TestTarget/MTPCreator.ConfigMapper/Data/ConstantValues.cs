// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="ConstantValues.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Siemens.MTPCreator.Interfaces.ConfigHandler.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    class ConstantValues : IConstantValues
    {
        public ConstantValues(string library, string mtpType, string mtpIndex, IList<string> stateTransient, string startIndex, string endIndex, string parameter, string parameterIndex, string type, string controlModule, string parameterDefinition, string procedureHealthView, string isSelfCompleting, string serviceControl, string servParam, string processValueIn, string processValueOut, string reportValue, string definition, string config)
        {
            Library = library ?? throw new ArgumentNullException(nameof(library));
            MtpType = mtpType ?? throw new ArgumentNullException(nameof(mtpType));
            MtpIndex = mtpIndex ?? throw new ArgumentNullException(nameof(mtpIndex));
            StateTransient = stateTransient ?? throw new ArgumentNullException(nameof(stateTransient));
            StartIndex = startIndex ?? throw new ArgumentNullException(nameof(startIndex));
            EndIndex = endIndex ?? throw new ArgumentNullException(nameof(endIndex));
            Parameter = parameter ?? throw new ArgumentNullException(nameof(parameter));
            ParameterIndex = parameterIndex ?? throw new ArgumentNullException(nameof(parameterIndex));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            ControlModule = controlModule ?? throw new ArgumentNullException(nameof(controlModule));
            ParameterDefinition = parameterDefinition ?? throw new ArgumentNullException(nameof(parameterDefinition));
            ProcedureHealthView = procedureHealthView ?? throw new ArgumentNullException(nameof(procedureHealthView));
            IsSelfCompleting = isSelfCompleting ?? throw new ArgumentNullException(nameof(isSelfCompleting));
            ServiceControl = serviceControl ?? throw new ArgumentNullException(nameof(serviceControl));
            ServParam = servParam ?? throw new ArgumentNullException(nameof(servParam));
            ProcessValueIn = processValueIn ?? throw new ArgumentNullException(nameof(processValueIn));
            ProcessValueOut = processValueOut ?? throw new ArgumentNullException(nameof(processValueOut));
            ReportValue = reportValue ?? throw new ArgumentNullException(nameof(reportValue));
            Definition = definition ?? throw new ArgumentNullException(nameof(definition));
            Config = config ?? throw new ArgumentNullException(nameof(config));
        }

        //todo: remove this after td, fix
        public ConstantValues()
        {
            Library = "PFL 2(default)";
            MtpType = "type";
            MtpIndex = "indexMTP";
            StateTransient = new List<string>()
            {
              "StateTransient.starting"
            , "StateTransient.running"
            , "StateTransient.holding"
            , "StateTransient.restarting"
            , "StateTransient.pausing"
            , "StateTransient.resuming"
            , "StateTransient.completing"
            , "StateTransient.stopping"
            , "StateTransient.aborting"
            , "StateTransient.resetting"
            };
            StartIndex = "startIndex";
            EndIndex = "endIndex";
            Parameter = "parameter";
            ParameterIndex = "parameterIndex";
            Type = "type";
            ControlModule = "controlModule";
            ParameterDefinition = "parameterDefinition";
            ProcedureHealthView = "ProcedureHealthView";
            IsSelfCompleting = "IsSelfCompleting";
            ServiceControl = "ServiceControl";
            ServParam = "ServParam";
            ProcessValueIn = "ProcessValueIn";
            ProcessValueOut = "ProcessValueOut";
            ReportValue = "reportValue";
            Definition = "definition";
            Config = "config";
        }

        public string Library { get; set; }
        public string MtpType { get; set; }
        public string MtpIndex { get; set; }
        public IList<string> StateTransient { get; set; }
        public string StartIndex { get; set; }
        public string EndIndex { get; set; }
        public string Parameter { get; set; }
        public string ParameterIndex { get; set; }
        public string Type { get; set; }
        public string ControlModule { get; set; }
        public string ParameterDefinition { get; set; }
        public string ProcedureHealthView { get; set; }
        public string IsSelfCompleting { get; set; }
        public string ServiceControl { get; set; }
        public string ServParam { get; set; }
        public string ProcessValueIn { get; set; }
        public string ProcessValueOut { get; set; }
        public string ReportValue { get; set; }
        public string Definition { get; set; }
        public string Config { get; set; }
    }
}
