using System;
using System.Globalization;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Layouts
{
    public class SimpleLayout : Layout
    {
        private const string DefaultDateFormat = "M/d/yyyy h:mm:ss tt";
        private const string DefaultFormat = "{0} - {1} - {2}";

        public SimpleLayout()
        {
            this.DateFormat = DefaultDateFormat;
            this.Format = DefaultFormat;
        }
    }
}
