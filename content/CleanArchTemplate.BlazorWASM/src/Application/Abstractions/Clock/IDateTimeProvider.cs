namespace CleanArchTemplate.BlazorWASM.Application.Abstractions.Clock;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}