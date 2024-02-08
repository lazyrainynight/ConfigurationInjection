namespace ConfigurationInjection.Services;

public class HelloService : IHelloService
{
    public void SayHello()
    {
        Console.WriteLine($"Hello from {nameof(HelloService)}");
    }
}
