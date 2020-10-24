using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;

namespace SliceOfCode.Logging.Api.Logging
{
    public class LoggingInterceptor : IInterceptor
    {
        private readonly ILogger<LoggingInterceptor> _logger;

        public LoggingInterceptor(ILogger<LoggingInterceptor> logger)
        {
            _logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            _logger.LogDebug($"Consuming method {invocation.Method} from {invocation.TargetType.FullName}");
            invocation.Proceed();
            _logger.LogDebug($"Consumed method {invocation.Method} from {invocation.TargetType.FullName}");
        }
    }
}