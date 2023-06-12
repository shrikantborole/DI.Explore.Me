// See https://aka.ms/new-console-template for more information
using DI.Common.Explore.Me.Implementation.Logger;
using DI.Common.Explore.Me.Implementation.Report;
using DI.Common.Explore.Me.Interface;
using DI.TypesToRegister.Explore.Me;
using DI.TypesToRegister.Explore.Me.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .UseDefaultServiceProvider((context, options) =>
    {
        options.ValidateScopes = true;
    })
    .ConfigureServices((context, services) =>
    {
        services.AddTransient(typeof(IReport<>), typeof(CSVReport<>));
        //services.AddTransient<ILogger, FileLogger>();
        services.AddTransient<BussinessLogic>();

        services.AddTransient<ISQLLoggerFactory, SQLLoggerFactory>();

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

        //services.TryAddTransient<ILogger, ConsoleLogger>();

        services.AddOptions<LoggerConfiguration>()
        .Configure<IConfiguration>((options, config) =>
        {
            config.GetSection("Logger").Bind(options);
        });
    })
    .Build();

var rabbitMQSartup = host.Services.GetRequiredService<BussinessLogic>();
rabbitMQSartup.Run();