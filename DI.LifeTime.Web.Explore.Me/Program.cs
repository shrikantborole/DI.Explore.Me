using DI.Common.Explore.Me.Implementation;
using DI.Common.Explore.Me.Implementation.Logger;
using DI.Common.Explore.Me.Interface;
using DI.LifeTime.Web.Explore.Me;
using LifeTime.Explore.Me;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region LifeTime Example
//Scope: Singleton Example
//builder.Services.AddSingleton<ILifeTimeExample, LifeTimeExample>();

//Scope: Transient Example
//builder.Services.AddTransient<ILifeTimeExample, LifeTimeExample>();

//Scope: Scoped Example
builder.Services.AddScoped<ILifeTimeExample, LifeTimeExample>();
#endregion

builder.Services.AddTransient<IBusDemoOne, BusDemoOne>();
builder.Services.AddTransient<IBusDemoTwo, BusDemoTwo>();

#region LazyLoading

builder.Services.AddTransient<DI.Common.Explore.Me.Interface.ILogger, ConsoleLogger>();
builder.Services.AddTransient<Lazy<IILazyLoading>>((serviceProvider) =>
{
    return new Lazy<IILazyLoading>(() =>
    {
        var scopeForLogger = serviceProvider.GetService<DI.Common.Explore.Me.Interface.ILogger>();
        return new LazyLoading(scopeForLogger);
    });
});

#endregion

builder.Services.AddHttpClient<IHttpClientDemo, HttpClientDemo>()
           .ConfigureHttpClient(client =>
           {
               client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
           });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
