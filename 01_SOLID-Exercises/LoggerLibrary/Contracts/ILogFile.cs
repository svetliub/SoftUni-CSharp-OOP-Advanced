using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Contracts
{
    public interface ILogFile
    {
        string Path { get; }

        int Size { get; }

        void WriteToFile(string errorLog);
    }
}
