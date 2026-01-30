using CManager.Application.Interfaces;
using CManager.Application.Services;
using CManager.Infrastructure.Repositories;
using CManager.Presentation.ConsoleApp.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<MenuController>();

builder.Services.AddSingleton<ICustomerRepository>(new FileStorageRepository(@"c:\data\CManager\customers.json"));
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<MenuController>();

var app = builder.Build();

var controller = app.Services.GetRequiredService<MenuController>();

controller.Run();

