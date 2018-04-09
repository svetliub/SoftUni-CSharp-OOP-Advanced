using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary
{
    public class Error : IError
    {
        public Error(DateTime dateTime, string message, ErrorLevel errorLevel)
        {
            this.DateTime = dateTime;
            this.Message = message;
            this.ErrorLevel = errorLevel;
        }

        public DateTime DateTime { get; }

        public string Message { get; }

        public ErrorLevel ErrorLevel { get; }
    }
}
