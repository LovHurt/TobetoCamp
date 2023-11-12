using System;

namespace OOP3
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("It has been logged to file database");
        }
    }
}