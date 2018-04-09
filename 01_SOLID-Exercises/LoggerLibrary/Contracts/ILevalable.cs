using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Contracts
{
    public interface ILevalable
    {
        ErrorLevel ErrorLevel { get; }
    }
}
