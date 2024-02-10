namespace CleanArchTemplate.BlazorWebApp.Application.Abstractions.Clock;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}