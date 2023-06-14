using DI.Common.Explore.Me.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DI.LifeTime.Explore.Me
{
    public class BussinessLogicScoped
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public BussinessLogicScoped(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;

        }
        public void Run()
        {

            using var scope = _serviceScopeFactory.CreateScope();

            var _productExport = scope.ServiceProvider.GetRequiredService<IProductExpoter>();
            var _productImport = scope.ServiceProvider.GetRequiredService<IProductImporter>();


            Console.WriteLine($"{this.GetType().FullName} : {System.Reflection.MethodBase.GetCurrentMethod().Name} - Imported 2 Times and Exported 1 Time");
            Console.WriteLine("------------------------------");

            _productImport.Import();
            _productImport.Import();
            _productImport.Import();
            Console.WriteLine($"Output for Imported");
            _productImport.OutPut();
            Console.WriteLine("------------------------------");


            _productExport.Export();
            Console.WriteLine($"Output for Exporter");
            _productExport.OutPut();
        }
    }
}
