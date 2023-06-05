namespace DI.Basic.Explore.Me.Interface
{
    public interface ILogger
    {
        public void Log(string message);
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("File Logger Called");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console Logger Callled");
        }
    }
}
