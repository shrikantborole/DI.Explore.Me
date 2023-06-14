using LifeTime.Explore.Me;
using Microsoft.AspNetCore.Mvc;

namespace DI.LifeTime.Web.Explore.Me.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {

        private readonly ILogger<DemoController> _logger;
        private IBusDemoTwo _busDemoTwo;
        private readonly IBusDemoOne _busDemoOne;

        public DemoController(ILogger<DemoController> logger, IBusDemoTwo busDemoTwo, IBusDemoOne busDemoOne)
        {
            _logger = logger;
            _busDemoTwo = busDemoTwo;
            _busDemoOne = busDemoOne;
        }


        [HttpGet(Name = "lifeTimeDemo")]
        public IActionResult Get()
        {
            _busDemoOne.Run();
            _busDemoOne.Run();


            _busDemoTwo.Run();
            _busDemoTwo.Run();

            return Ok();
        }
    }
}