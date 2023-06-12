using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In Console Logger - {message}");
        }
    }
}
