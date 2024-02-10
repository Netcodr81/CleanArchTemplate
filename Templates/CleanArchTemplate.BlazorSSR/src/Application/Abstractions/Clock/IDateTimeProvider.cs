namespace CleanArchTemplate.BlazorSSR.Application.Abstractions.Clock;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}