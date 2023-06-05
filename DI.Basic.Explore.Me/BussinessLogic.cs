using DI.Basic.Explore.Me.Interface;

namespace DI.Basic.Explore.Me
{
    public class BussinessLogic
    {
        private readonly ILogger _logger;
        public BussinessLogic(ILogger logger)
        {
            _logger= logger;
        }

        public void Calculate()
        {
            _logger.Log(this.GetType().FullName);
        }
    }
}
