using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace SliceOfCode.Logging.Api.Logging
{
    public class LoggingFilter : IExceptionFilter, IActionFilter
    {
        private readonly ILogger<LoggingFilter> _logger;

        public LoggingFilter(ILogger<LoggingFilter> logger)
        {
            _logger = logger;
        }
        
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogDebug($"Request started: {context.HttpContext.Request.Path}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogDebug($"Request finished: {context.HttpContext.Request.Path}");
        }

        public void OnException(ExceptionContext context)
        {
            _logger.LogError($"Request throw error: {context.Exception.Message}");
        }
    }
}