using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary;
using LoggerLibrary.Contracts;
using LoggerLibrary.Factories;

namespace Loggers.App
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] errorArgs = input.Split('|');
                string level = errorArgs[0];
                string dateTime = errorArgs[1];
                string message = errorArgs[2];

                IError error = errorFactory.CreateFactory(dateTime, level, message);
                this.logger.Log(error);
            }

            Console.WriteLine("Logger info");
            foreach (var appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
