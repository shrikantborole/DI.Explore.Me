using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation.Logger
{
    public class SQLLoggerFactory : ISQLLoggerFactory
    {
        public ILogger CreateRefernceGenerator(string connectionString)
        {
           return new SQLLogger(connectionString);
        }
    }
}
