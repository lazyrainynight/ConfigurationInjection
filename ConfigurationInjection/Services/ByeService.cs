using ConfigurationInjection.Config;
using Microsoft.Extensions.Options;

namespace ConfigurationInjection.Services;

public class ByeService : IByeService
{
    private readonly ServiceConfiguration _configuration;

    public ByeService(IOptions<ServiceConfiguration> options)
    {
        _configuration = options.Value;
    }

    public void SayBye()
    {
        Console.WriteLine($"Bye from {nameof(ByeService)}. I love you {_configuration.HowMuchLove}");
    }
}
