using DI.Common.Explore.Me.Implementation;
using DI.Common.Explore.Me.Interface;
using LifeTime.Explore.Me;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<IDemoCounter, DemoCounter>();
//builder.Services.AddTransient<IDemoCounter, DemoCounter>();
builder.Services.AddScoped<ILifeTimeExample, LifeTimeExample>();

builder.Services.AddTransient<IBusDemoOne, BusDemoOne>();
builder.Services.AddTransient<IBusDemoTwo, BusDemoTwo>();

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
