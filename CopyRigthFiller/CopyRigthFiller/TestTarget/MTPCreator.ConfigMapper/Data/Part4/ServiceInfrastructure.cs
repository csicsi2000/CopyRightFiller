// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="ServiceInfrastructure.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.Interfaces.ConfigHandler.Part4;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part4
{
    /// <summary>
    /// Class implementing the Service configuration
    /// </summary>
    public class ServiceInfrastructure : IServiceInfrastructure
    {
        public string ProcedureParamLink { get; set; }
        public string ProcedureHealth { get; set; }
        public string Configuration { get; set; }
        public string Procedure { get; set; }
        public string Process { get; set; }
        public string Report { get; set; }
    }
}
