using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asteya.Infrastructure
{
    public interface ILoggingService
    {
        void LogInformation(string content);
        void LogException(Exception exception);
    }
}
