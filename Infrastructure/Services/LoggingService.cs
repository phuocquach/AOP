using System;

namespace Asteya.Infrastructure
{
    public class LoggingService : ILoggingService
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public void LogInformation(string content)
        {
            Console.WriteLine(content);
        }
    }
}
