using DI.LifeTime.Explore.Me;
using DI.LifeTime.Explore.Me.Implementation;
using DI.LifeTime.Explore.Me.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .UseDefaultServiceProvider((context, options) =>
    {
        options.ValidateScopes = true;
    })
    .ConfigureServices((context, services) =>
    {
        //AddScoped :- The lifetime determines weather the DI container will create a new instance by container
        //It's like a subcontainer
        #region Scoped

        //services.AddScoped<IProductExpoter, ProductExporter>();
        //services.AddScoped<IProductImporter, ProductImporter>();

        //services.AddTransient<BussinessLogicScoped>();

        //services.AddSingleton<ILifeTimeExample, LifeTimeExample>();

        #endregion

        //AddTransient :- A new instance is created every time a type is requested by container
        #region Transient

        services.AddTransient<IProductExpoter, ProductExporter>();
        services.AddTransient<IProductImporter, ProductImporter>();

        services.AddTransient<BussinessLogic>();

        services.AddTransient<ILifeTimeExample, LifeTimeExample>();

        #endregion

        //AddSingleton :- A new instance is created once and reused from then onwards by container
        #region Singleton

        //services.AddTransient<IProductExpoter, ProductExporter>();
        //services.AddTransient<IProductImporter, ProductImporter>();

        //services.AddTransient<BussinessLogic>();

        //services.AddSingleton<ILifeTimeExample, LifeTimeExample>();

        #endregion

    })
    .Build();

var productImporter = host.Services.GetRequiredService<BussinessLogic>();
productImporter.Run();