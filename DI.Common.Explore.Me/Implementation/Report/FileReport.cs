using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation.Report
{
    public class FileReport<T> : IReport<T>
    {
        public void Extract(string path, T inputParameter)
        {
            Console.WriteLine($"{this.GetType().FullName} : {System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
    }
}
