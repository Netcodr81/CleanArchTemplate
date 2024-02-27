using CleanArchTemplate.Api.Application.Abstractions.Clock;

namespace CleanArchTemplate.Api.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}