using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Contracts
{
    public interface IAppender : ILevalable
    {
        ILayout Layout { get; }

        void Append(IError error);
    }
}
