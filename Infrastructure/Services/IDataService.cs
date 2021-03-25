using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asteya.Infrastructure
{
    public interface IDataService
    {
        void CreateLog(string log);
        void CreateLog(Exception exception);
    }
}
