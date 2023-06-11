using DI.LifeTime.Explore.Me.Interface;

namespace DI.LifeTime.Explore.Me.Implementation
{
    public class ProductExporter : IProductExpoter
    {
        private readonly ILifeTimeExample _lifeTimeExample;

        public ProductExporter(ILifeTimeExample   lifeTimeExample)
        {
            _lifeTimeExample = lifeTimeExample;
        }
        public void Export()
        {
            _lifeTimeExample.DecrementByOne();
        }

        public void OutPut()
        {
            _lifeTimeExample.OutPut();
        }
    }
}
