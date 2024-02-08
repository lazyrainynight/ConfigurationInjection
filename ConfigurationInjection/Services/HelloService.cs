using ConfigurationInjection.Config;
using Microsoft.Extensions.Options;

namespace ConfigurationInjection.Services;

public class HelloService : IHelloService
{
    private readonly ServiceConfiguration _configuration;

    public HelloService(IOptions<ServiceConfiguration> options)
    {
        _configuration = options.Value;
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello from {nameof(HelloService)} - {_configuration.ServiceName}");
    }
}
