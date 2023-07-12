using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation.Logger
{
    public class SQLLogger : ILogger
    {
        private readonly string _connecttionString;
        public SQLLogger(string connection)
        {
                _connecttionString= connection; 
        }
        public void Log(string message)
        {
            Console.WriteLine($"In SQL Logger {message}");
        }
    }
}
