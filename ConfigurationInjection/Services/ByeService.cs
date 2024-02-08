namespace ConfigurationInjection.Services;

public class ByeService : IByeService
{
    public void SayBye()
    {
        Console.WriteLine($"Bye from {nameof(ByeService)}");
    }
}
