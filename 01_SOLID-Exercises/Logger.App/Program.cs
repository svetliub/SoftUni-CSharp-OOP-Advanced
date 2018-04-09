using System;
using System.Collections.Generic;
using System.Linq;
using LoggerLibrary;
using LoggerLibrary.Appenders;
using LoggerLibrary.Contracts;
using LoggerLibrary.Factories;
using LoggerLibrary.Loggers;

namespace Loggers.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = InitializeIlogger();
            ErrorFactory errorFactory = new ErrorFactory();
            Engine engine = new Engine(logger, errorFactory);

            engine.Run();
        }

        static ILogger InitializeIlogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);

            int appenderCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appenderCount; i++)
            {
                string[] args = Console.ReadLine().Split().ToArray();
                string appenderType = args[0];
                string layoutType = args[1];
                string errorLevel = "INFO";

                if (args.Length == 3)
                {
                    errorLevel = args[2];
                }

                IAppender appender = appenderFactory.CreateAppender(appenderType, errorLevel, layoutType);
                appenders.Add(appender);
            }

            ILogger logger = new Logger(appenders);

            return logger;
        }
    }
}
