// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="ConnectionsData.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.Interfaces.ConfigHandler.Part2;
using System.Collections.Generic;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part2
{
    /// <summary>
    /// Filters for Connections
    /// </summary>
    public class ConnectionsData : IConnectionsData
    {
        /// <summary>
        /// Name of the objects that will be exported as TopologyObject if it contains this string
        /// </summary>
        public IList<string> Connection { get; internal set; }
        /// <summary>
        /// Name of the objects that will be exported as Junction if it contains this string
        /// </summary>
        public IList<string> Pipe { get; internal set; }
        /// <summary>
        /// Name of the objects that will be exported as Termination if it contains this string
        /// </summary>
        public IList<string> MeasurementLine { get; internal set; }
        /// <summary>
        /// Name of the objects that will be exported as Sink if it contains this string
        /// </summary>
        public IList<string> FunctionLine { get; internal set; }
    }
}
