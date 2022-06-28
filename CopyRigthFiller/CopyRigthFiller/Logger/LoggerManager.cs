using Interfaces.CopyRightFiller.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopyRigthFiller.Logger
{
    public class LoggerManager :ILoggerManager
    {
        List<ILogger> allLogger;

        public LoggerManager(List<ILogger> loggers)
        {
            allLogger = loggers;
        }

        public void WriteLine(string content)
        {
            foreach(var logger in allLogger)
            {
                logger.WriteLog(content);
            }
        }
    }
}
