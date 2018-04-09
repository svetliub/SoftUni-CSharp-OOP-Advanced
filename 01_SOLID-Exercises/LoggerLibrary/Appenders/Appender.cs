using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Contracts;

namespace LoggerLibrary.Appenders
{
    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout, ErrorLevel errorLevel)
        {
            this.Layout = layout;
            this.ErrorLevel = errorLevel;
        }

        public ILayout Layout { get; }

        public ErrorLevel ErrorLevel { get; }

        public int MessagesAppended { get; private set; }

        public virtual void Append(IError error)
        {
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            return
                $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ErrorLevel.ToString()}, Messages appended: {this.MessagesAppended}";
        }
    }
}
