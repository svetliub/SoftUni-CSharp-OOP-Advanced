using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Loggers
{
    public class Logger : ILogger
    {
        IEnumerable<IAppender> appenders;

        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>) this.appenders;

        public void Log(IError error)
        {
            foreach (var appender in appenders)
            {
                if (appender.ErrorLevel <= error.ErrorLevel)
                {
                    appender.Append(error);
                }
            }
        }
    }
}
