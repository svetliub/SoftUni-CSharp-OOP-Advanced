using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Layouts
{
    public class JsonLayout : Layout
    {
        private const string DefaultDateFormat = "M/d/yyyy h:mm:ss tt";

        private string DefaultFormat = "{{" + Environment.NewLine +
                                            "\t\"Date\": {0}," + Environment.NewLine +
                                            "\t\"Level\": {1}," + Environment.NewLine +
                                            "\t\"Message\": {2}" + Environment.NewLine +
                                       "}}";

        public JsonLayout()
        {
            this.DateFormat = DefaultDateFormat;
            this.Format = DefaultFormat;
        }
    }
}
