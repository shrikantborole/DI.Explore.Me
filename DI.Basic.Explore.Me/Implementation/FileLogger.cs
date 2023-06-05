using DI.Basic.Explore.Me.Interface;

namespace DI.Basic.Explore.Me.Implementation
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In File Logger {message}");
        }
    }
}
