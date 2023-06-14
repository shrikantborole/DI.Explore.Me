using DI.Common.Explore.Me.Interface;

namespace LifeTime.Explore.Me
{
    public interface IBusDemoTwo
    {
        public void Run();
    }
    public class BusDemoTwo : IBusDemoTwo
    {
        private readonly ILifeTimeExample _lifeTimeExample;
        public BusDemoTwo(ILifeTimeExample lifeTimeExample)
        {
            _lifeTimeExample = lifeTimeExample;
        }

        public void Run()
        {
            _lifeTimeExample.IncrementByOne();
            _lifeTimeExample.OutPut();
        }
    }
}
