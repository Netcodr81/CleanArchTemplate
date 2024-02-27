namespace CleanArchTemplate.BlazorServer.Application.Abstractions.Clock;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}