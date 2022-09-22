using System;

namespace Factory_Loggers
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerManager loggerManager = new LoggerManager();//loggermanager created
            ILoggerFactory loggerFactory = loggerManager.CreateFactory(LogTypes.FileLogger);//FileLogger or DbLogger factory object products here.
            ILogger logger = loggerFactory.Create();//a logger named object produces in loggerFactory object
            Console.WriteLine(logger.Log("Hellow World!"));//writes what is log item

            Console.ReadKey();
        }
    }
}
