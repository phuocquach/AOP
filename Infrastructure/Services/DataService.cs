using System;

namespace Asteya.Infrastructure
{
    public class DataService : IDataService
    {
        public void CreateLog(string log)
        {
            Console.WriteLine(log);
        }

        public void CreateLog(Exception exception)
        {
            Console.WriteLine(exception.ToString());
        }
    }
}
