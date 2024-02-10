using CleanArchTemplate.BlazorSSR.Application.Abstractions.Clock;

namespace CleanArchTemplate.BlazorSSR.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}