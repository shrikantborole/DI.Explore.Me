// See https://aka.ms/new-console-template for more information
using DI.Common.Explore.Me.Implementation.Logger;
using DI.Common.Explore.Me.Implementation.Report;
using DI.Common.Explore.Me.Interface;
using DI.TypesToRegister.Explore.Me;
using DI.TypesToRegister.Explore.Me.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .UseDefaultServiceProvider((context, options) =>
    {
        options.ValidateScopes = true;
    })
    .ConfigureServices((context, services) =>
    {
        //How to register Generic type
        services.AddTransient(typeof(IReport<>), typeof(CSVReport<>));

        //How to register normal class
        //services.AddTransient<ILogger, FileLogger>();
        //services.TryAddTransient<ILogger, ConsoleLogger>();

        //Register Single Class
        services.AddTransient<BussinessLogic>();

        //Register a class with ctor, ISQLLoggerFactory is wrapper class around it. 
        services.AddTransient<ISQLLoggerFactory, SQLLoggerFactory>();

        //AB Testing, based on the key in the appSetting, the dependency is injected.
        services.AddTransient<FileLogger>();
        services.AddTransient<ConsoleLogger>();
        services.AddTransient<ILogger>((serviceProvider) =>
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            if (configuration.GetValue<string>("Logger:Target").Equals("File", StringComparison.InvariantCulture))
            {
                return serviceProvider.GetRequiredService<FileLogger>();
            }
            return serviceProvider.GetRequiredService<ConsoleLogger>();
        });

        //Mapping of the appSetting to the model
        services.AddOptions<LoggerConfiguration>()
        .Configure<IConfiguration>((options, config) =>
        {
            config.GetSection("Logger").Bind(options);
        });
    })
    .Build();

var typesToRegister = host.Services.GetRequiredService<BussinessLogic>();
typesToRegister.Run();