using DI.Common.Explore.Me.Interface;
using DI.TypesToRegister.Explore.Me.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ILogger = DI.Common.Explore.Me.Interface.ILogger;

namespace DI.TypesToRegister.Explore.Me
{
    public class BussinessLogic
    {
        private readonly ILogger _logger;
        private readonly IReport<string> _report;
        private readonly IOptions<LoggerConfiguration> _optionSnapShot;

        public BussinessLogic(ILogger logger, IReport<string> report, IOptions<LoggerConfiguration> optionsSnapshot)
        {
            _logger = logger;
            _report = report;
            _optionSnapShot = optionsSnapshot;
        }

        #region DIInjectionWithCtorClass
        //public BussinessLogic(ISQLLoggerFactory sQLLoggerFactory, IReport<string> report, IOptions<LoggerConfiguration> optionsSnapshot)
        //{
        //    _report = report;
        //    _optionSnapShot = optionsSnapshot;
        //    _logger = sQLLoggerFactory.CreateRefernceGenerator(_optionSnapShot.Value.ConnectionString);
        //}
        #endregion
        public void Run()
        {
            _logger.Log($"{this.GetType().FullName} : {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            _report.Extract(_optionSnapShot.Value.FilePath, string.Empty);
        }
    }
}
