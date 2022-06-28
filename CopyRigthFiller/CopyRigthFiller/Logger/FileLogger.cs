using Interfaces.CopyRightFiller.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CopyRigthFiller.Logger
{
    public class FileLogger : ILogger
    {
        string _target;
        public FileLogger(string file)
        {
            _target = file;
        }
        public void WriteLog(string content)
        {
            File.AppendAllText(_target, content + Environment.NewLine);
        }
    }
}
