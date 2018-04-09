namespace LoggerLibrary.Contracts
{
    public interface ILayout
    {
        string DateFormat { get; set; }

        string Format { get; set; }

        string FormatError(IError error);
    }
}