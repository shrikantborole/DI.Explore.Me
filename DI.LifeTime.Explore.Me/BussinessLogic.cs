using DI.LifeTime.Explore.Me.Interface;

namespace DI.LifeTime.Explore.Me
{
    public class BussinessLogic
    {
        private readonly IProductImporter _productImport;
        private readonly IProductExpoter _productExport;

        public BussinessLogic(IProductExpoter productExport, IProductImporter productImport)
        {
            _productExport = productExport;
            _productImport = productImport;
        }
        
        public void Run()
        {
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