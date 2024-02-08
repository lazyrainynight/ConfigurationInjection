using ConfigurationInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddHostedService<Runner>();

var host = builder.Build();
await host.RunAsync();
