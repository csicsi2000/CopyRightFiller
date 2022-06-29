// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="TopologyObjectsData.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using Siemens.MTPCreator.Interfaces.ConfigHandler.Part2;
using System.Collections.Generic;

namespace Siemens.MTPCreator.ConfigMapper.Data.Part2
{
    // Filter for TopologyObjects
    public class TopologyObjectsData : ITopologyObjectsData
    {
        // filter for TopologyObject
        public IList<string> TopologyObject { get; internal set; }

        // filter for Junction
        public IList<string> Junction { get; internal set; }

        // filter for Termination
        public IList<string> Termination { get; internal set; }

        // filter for Sink
        public IList<string> Sink { get; internal set; }

        // filter for Source
        public IList<string> Source { get; internal set; }
    }
}
