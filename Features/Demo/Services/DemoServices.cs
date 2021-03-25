using Microsoft.Extensions.Logging;

namespace Asteya.Features.Services
{
    public class DemoServices : IDemoServices
    {
        public DemoServices() { }
        public string Method()
        {
            return "Method is excuted";
        }
    }
}
