using DI.Common.Explore.Me.Interface;

namespace DI.Common.Explore.Me.Implementation
{
    public class LifeTimeExample : ILifeTimeExample
    {
        private int COUNT = 0;
        public void DecrementByOne()
        {
            --COUNT;
        }

        public void IncrementByOne()
        {
            ++COUNT;
        }

        public void OutPut()
        {
            Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod().Name} Total Count - {COUNT}");
        }
    }
}
