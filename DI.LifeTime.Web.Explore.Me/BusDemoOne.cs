using DI.Common.Explore.Me.Interface;

namespace LifeTime.Explore.Me
{
    public interface IBusDemoOne
    {
        public void Run();
    }
    public class BusDemoOne : IBusDemoOne
    {
        private readonly ILifeTimeExample _lifeTimeExample;
        public BusDemoOne(ILifeTimeExample lifeTimeExample)
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
