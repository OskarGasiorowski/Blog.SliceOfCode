namespace SliceOfCode.Logging.Api.Services
{
    public interface ISampleService
    {
        string Get();
    }
    
    public class SampleService : ISampleService
    {
        public string Get()
        {
            return "Hello World!";
        }
    }
}