using System;
using Microsoft.AspNetCore.Mvc;

namespace SliceOfCode.Logging.Api.Logging
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequestLoggingAttribute : ServiceFilterAttribute
    {
        public RequestLoggingAttribute() : base(typeof(LoggingFilter)) { }
    }
}