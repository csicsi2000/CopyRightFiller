// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Template Compan" file="ExportMode.cs">
// Copyright © Company 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Siemens.MTPCreator.Interfaces._Interfaces.ConfigHandler.Data;

namespace Siemens.MTPCreator.ConfigMapper.Data
{
    /// <summary>
    /// Export modes of the NAMUR parts
    /// </summary>
    public class ExportMode : IExportMode
    {
        public bool Part2 { get; set; }
        public bool Part3 { get; set; }
        public bool Part4 { get; set; }
    }
}
