using ConfigurationInjection.Services;
using Microsoft.Extensions.Hosting;

namespace ConfigurationInjection;

public class Runner : IHostedService
{
    private readonly IHelloService _helloService;

    public Runner(IHelloService helloService)
    {
        _helloService = helloService;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _helloService.SayHello();
        Console.WriteLine($"[{nameof(Runner)}.{nameof(StartAsync)}()][{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"[{nameof(Runner)}.{nameof(StopAsync)}()][{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
    }
}
