using CleanArchTemplate.BlazorWASM.Application.Abstractions.Clock;

namespace CleanArchTemplate.BlazorWASM.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}