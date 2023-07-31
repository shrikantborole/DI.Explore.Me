using LifeTime.Explore.Me;
using Microsoft.AspNetCore.Mvc;

namespace DI.LifeTime.Web.Explore.Me.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DemoController : ControllerBase
    {
        static int count = 0;
        private readonly ILogger<DemoController> _logger;
        private IBusDemoTwo _busDemoTwo;
        private readonly IBusDemoOne _busDemoOne;
        private readonly IHttpClientDemo _iHttpClientDemo;

        public DemoController(ILogger<DemoController> logger, IBusDemoTwo busDemoTwo, IBusDemoOne busDemoOne, IHttpClientDemo iHttpClientDemo)
        {
            _logger = logger;
            _busDemoTwo = busDemoTwo;
            _busDemoOne = busDemoOne;
            _iHttpClientDemo = iHttpClientDemo;
        }


        [HttpGet]
        [Route("lifeTime")]
        public IActionResult Get()
        {
            ++count;
            _busDemoOne.Run();
            _busDemoOne.Run();


            _busDemoTwo.Run();
            _busDemoTwo.Run();

            Console.WriteLine($"Static varibale Count :- {count}");
            return Ok();
        }

        [HttpGet]
        [Route("httpClient")]
        public async Task<IActionResult> GetUser()
        {
            var users = await _iHttpClientDemo.GetUsersAsync();
            return Ok(users);
        }
    }
}