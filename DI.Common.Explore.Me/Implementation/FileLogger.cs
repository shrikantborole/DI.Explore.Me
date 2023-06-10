using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"In File Logger {message}");
        }
    }
}
