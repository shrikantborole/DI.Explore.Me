using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In Console Logger - {message}");
        }
    }
}
