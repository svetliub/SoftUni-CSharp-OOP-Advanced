using LoggerLibrary.Contracts;
using System.Globalization;

namespace LoggerLibrary.Layouts
{
    public abstract class Layout : ILayout
    {
        public string DateFormat { get; set; }
        public string Format { get; set; }

        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(this.DateFormat, CultureInfo.InvariantCulture);
            string formattedError = string.Format(this.Format, dateString, error.ErrorLevel, error.Message);

            return formattedError;
        }
    }
}
