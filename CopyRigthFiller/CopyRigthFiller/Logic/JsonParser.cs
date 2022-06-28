// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Siemens AG" file="JsonParser.cs">
// Copyright © Siemens AG 2022. All rights reserved. Confidential.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using CopyRigthFiller.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CopyRigthFiller.Logic
{
    public static class JsonParser
    {
        public static Configs GetConfig()
        {
            string content = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"config.json"));
            return JsonConvert.DeserializeObject<Configs>(content);
        }
    }
}
