using LifeTime.Explore.Me;
using Microsoft.AspNetCore.Mvc;

namespace DI.LifeTime.Web.Explore.Me.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
            _lazyloading.Value.Run();
            return Ok();
        }
    }
}