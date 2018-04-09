using System;
using System.Collections.Generic;

namespace LoggerLibrary.Contracts
{
    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }

        void Log(IError error);
    }
}
