using System;

namespace LoggerLibrary.Contracts
{
    public interface IError : ILevalable
    {
        DateTime DateTime { get; }

        string Message { get; }
    }
}