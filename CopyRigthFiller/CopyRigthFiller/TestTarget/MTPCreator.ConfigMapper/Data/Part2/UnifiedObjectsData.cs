// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="UnifiedObjectsData.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.Interfaces.ConfigHandler.Part2;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part2
{
    /// <summary>
    /// Filter strings for TopologyObjjects and Connections
    /// </summary>
    public class UnifiedObjectsData : IUnifiedObjectsData
    {
        // filter for TopologyObject, Junction, Termination, Sink, Source
        public ITopologyObjectsData TopologyObjects { get; internal set; }

        // filter for Connection, Pipe, MeasurementLine, FunctionLine
        public IConnectionsData Connections { get; internal set; }
    }
}
