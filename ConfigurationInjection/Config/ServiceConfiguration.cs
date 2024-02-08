namespace ConfigurationInjection.Config;

public record ServiceConfiguration
{
    public required string ServiceName { get; init; }

    public required TimeSpan ImportJobInterval { get; init; }

    public required string Password { get; init; }

    public required int HowMuchLove { get; init; }
}
