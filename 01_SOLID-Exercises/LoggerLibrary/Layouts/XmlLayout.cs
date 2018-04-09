using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Layouts
{
    public class XmlLayout : Layout
    {
        private const string DefaultDateFormat = "HH:mm:ss dd-MMM-yyyy";
        private string DefaultFormat = "<log>" + Environment.NewLine +
                                    "\t<date>{0}</date>" + Environment.NewLine +
                                    "\t<level>{1}</level>" + Environment.NewLine +
                                    "\t<message>{2}</message>" + Environment.NewLine +
                                "</log>";

        public XmlLayout()
        {
            this.DateFormat = DefaultDateFormat;
            this.Format = DefaultFormat;
        }
    }
}
