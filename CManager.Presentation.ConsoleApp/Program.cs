using CManager.Presentation.ConsoleApp.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<MenuController>();

var app = builder.Build();

app.Services.GetRequiredService<MenuController>().Run();