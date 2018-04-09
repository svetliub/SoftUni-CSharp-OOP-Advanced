using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel errorLevel) : base(layout, errorLevel)
        { }

        public override void Append(IError error)
        {
            base.Append(error);
            string formattedError = this.Layout.FormatError(error);
            Console.WriteLine(formattedError);
        }
    }
}
