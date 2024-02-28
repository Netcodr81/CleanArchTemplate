using CleanArchTemplate.BlazorServer.Application.Abstractions.Clock;

namespace CleanArchTemplate.BlazorServer.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}