using DI.Basic.Explore.Me.Interface;

namespace DI.Basic.Explore.Me.Implementation
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In Console Logger - {message}");
        }
    }
}
