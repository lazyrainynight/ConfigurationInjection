using ConfigurationInjection.Services;
using Microsoft.Extensions.Hosting;

namespace ConfigurationInjection;

public class Runner : IHostedService
{
    private readonly IHelloService _helloService;

    private readonly IByeService _byeService;

    public Runner(
        IHelloService helloService,
        IByeService byeService)
    {
        _helloService = helloService;
        _byeService = byeService;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _helloService.SayHello();
        Console.WriteLine($"[{nameof(Runner)}.{nameof(StartAsync)}()][{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _byeService.SayBye();
        Console.WriteLine($"[{nameof(Runner)}.{nameof(StopAsync)}()][{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
    }
}
