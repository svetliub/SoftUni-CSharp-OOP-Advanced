using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Appenders
{
    public class FileAppender : Appender
    {
        private ILogFile logFile;

        public FileAppender(ILayout layout, ErrorLevel errorLevel, ILogFile logFile) : base(layout, errorLevel)
        {
            this.logFile = logFile;
        }

        public override void Append(IError error)
        {
            base.Append(error);
            string formattedError = this.Layout.FormatError(error);
            this.logFile.WriteToFile(formattedError);
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
