using DI.LifeTime.Explore.Me.Interface;

namespace DI.LifeTime.Explore.Me.Implementation
{
    internal class ProductImporter : IProductImporter
    {
        private readonly ILifeTimeExample _lifeTimeExample;

        public ProductImporter(ILifeTimeExample lifeTimeExample)
        {
            _lifeTimeExample = lifeTimeExample;
        }
        public void Import()
        {
            _lifeTimeExample.IncrementByOne();
        }
        public void OutPut()
        {
            _lifeTimeExample.OutPut();
        }
    }
}
