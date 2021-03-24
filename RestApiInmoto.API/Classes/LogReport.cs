using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInmoto.API.Classes
{
    public class LogReport
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }

        public LogReport()
        {

        }

        public LogReport(LogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        public static LogReport GenerateLogReport(LogLevel logLevel, string message) => new LogReport(logLevel, message);
    }
}
