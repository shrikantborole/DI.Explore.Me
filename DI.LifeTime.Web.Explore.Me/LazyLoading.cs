namespace DI.LifeTime.Web.Explore.Me
{
    public interface IILazyLoading
    {
        public void Run();
    }
    public class LazyLoading : IILazyLoading
    {
        private readonly Common.Explore.Me.Interface.ILogger _logger;
        public LazyLoading(Common.Explore.Me.Interface.ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            Thread.Sleep(60);
            _logger.Log("LazyLoading >> Run");
        }
    }
}
