using System.Diagnostics;
using System.Reflection;

namespace Asteya.Infrastructure.Core
{
    public class DispatchProxyCore<T> : DispatchProxy
        where T : class
    {
        private ILoggingService _loggingService;
        private IDataService _dataService;
        public T Target { get; private set; }
        public static T Decorate(T target, ILoggingService loggingService, IDataService dataService)
        {
            var proxy = Create<T, DispatchProxyCore<T>>()
                as DispatchProxyCore<T>;

            proxy._dataService = dataService;
            proxy._loggingService = loggingService;
            proxy.Target = target;

            return proxy as T;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            Stopwatch stopwatch = new();
            try
            {
                stopwatch.Start();
                _loggingService.LogInformation($"Start executing {targetMethod.Name}");

                var result = targetMethod.Invoke(Target, args);

                _loggingService.LogInformation($"Stop executing {targetMethod.Name}");
                stopwatch.Stop();

                _dataService.CreateLog($"{targetMethod.Name}:{stopwatch.ElapsedMilliseconds}");

                return result;
            }
            catch (TargetInvocationException exc)
            {
                _loggingService.LogInformation("Exception was logged");
                _dataService.CreateLog(exc.InnerException);
                throw exc.InnerException;
            }
        }
    }
}
