using Interfaces.CopyRightFiller.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopyRigthFiller.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void WriteLog(string content)
        {
            Console.WriteLine(content);
        }
    }
}
