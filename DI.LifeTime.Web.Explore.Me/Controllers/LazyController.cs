using LifeTime.Explore.Me;
using Microsoft.AspNetCore.Mvc;

namespace DI.LifeTime.Web.Explore.Me.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LazyController : ControllerBase
    {
        private readonly Lazy<IILazyLoading> _lazyloading;

        public LazyController(Lazy<IILazyLoading> lazyloading)
        {
            _lazyloading = lazyloading;   
        }


        [HttpGet(Name = "lazyLoadingDemo")]
        public IActionResult Get()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000); 
                Console.WriteLine($"Sleeping Therad for {i}");
            }
            _lazyloading.Value.Run();
            return Ok();
        }
    }
}