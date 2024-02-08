using ConfigurationInjection;
using ConfigurationInjection.Config;
using ConfigurationInjection.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddHostedService<Runner>();

// add service dependencies
builder.Services.AddTransient<IHelloService, HelloService>();
builder.Services.AddTransient<IByeService, ByeService>();

// configuration
var configuration = builder.Configuration.GetRequiredSection("ServiceConfiguration");
builder.Services.Configure<ServiceConfiguration>(configuration);

var host = builder.Build();
await host.RunAsync();
