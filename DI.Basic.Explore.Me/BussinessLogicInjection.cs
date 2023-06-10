using DI.Common.Explore.Me.Interface;

namespace DI.Basic.Explore.Me
{
    public class BussinessLogicInjection
    {
        private readonly ILogger _logger;
        public BussinessLogicInjection(ILogger logger)
        {
            _logger = logger;
        }

        public void Calculate()
        {
            _logger.Log($"BussinessLogicCtorInjection: - {this.GetType().FullName}");
        }
    }

    public class BussinessLogicMethodInjection
    {
        public void Calculate(ILogger logger)
        {
            logger.Log($"BussinessLogicMethodInjection: - {this.GetType().FullName}");
        }
    }

    class BussinessLogicPropertyInjection
    {
        private ILogger _logger;
        public ILogger LoggerInstance
        {
            private get
            {
                if (_logger == null)
                    throw new Exception("Initialize the logger");
                return _logger; 
            }
            set
            { _logger = value; }
        }

        public void Calculate()
        {
            _logger.Log($"BussinessLogicPropertyInjection: - {this.GetType().FullName}");
        }
    }
}
