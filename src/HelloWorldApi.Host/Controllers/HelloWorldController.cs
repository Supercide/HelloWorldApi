using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Host.Controllers
{
    [Route("hello")]
    public class HelloWorldController : Controller
    {
        [HttpGet("")]
        public string Get()
        {
            return "Hello world";
        }
    }
}
