using System;
using Microsoft.AspNetCore.Mvc;
using SliceOfCode.Logging.Api.Logging;
using SliceOfCode.Logging.Api.Services;

namespace SliceOfCode.Logging.Api.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }
        
        [HttpGet("sample")]
        public IActionResult Get()
        {
            var data = _sampleService.Get();
            return new OkObjectResult(data);
        }
        
        [HttpGet("sample-exception")]
        public IActionResult GetException()
        {
            throw new Exception("This is sample exception");
        }
    }
}