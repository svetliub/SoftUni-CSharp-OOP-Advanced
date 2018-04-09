using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Factories
{
    public class ErrorFactory
    {
        private const string DateFormat = "M/d/yyyy h:mm:ss tt";

        public IError CreateFactory(string dateTimeStr, string errorLevelStr, string message)
        {
            DateTime dateTime = DateTime.ParseExact(dateTimeStr, DateFormat, CultureInfo.InvariantCulture);
            ErrorLevel errorLevel = ParseErrorLevel(errorLevelStr);

            IError error = new Error(dateTime, message, errorLevel);

            return error;
        }

        private ErrorLevel ParseErrorLevel(string levelString)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(ErrorLevel), levelString);
                return (ErrorLevel)levelObj;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid ErrorLevel type!", e);
            }
        }
    }
}
