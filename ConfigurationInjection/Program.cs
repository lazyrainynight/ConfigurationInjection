using ConfigurationInjection;
using ConfigurationInjection.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddHostedService<Runner>();

// add service dependencies
builder.Services.AddTransient<IHelloService, HelloService>();
builder.Services.AddTransient<IByeService, ByeService>();

var host = builder.Build();
await host.RunAsync();
