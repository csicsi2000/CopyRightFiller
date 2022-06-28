// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="Configs.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace CopyRigthFiller.Data
{
    public class Configs
    {
        public string Pattern { get; set; }
        public string SearchedFolder { get; set; }
        public string DeleteLine { get; set; }
        public List<string> IgnoredFiles { get; set; }
        public string LogFilepath { get; set; }
    }
}
