using CleanArchTemplate.BlazorWebApp.Application.Abstractions.Clock;

namespace CleanArchTemplate.BlazorWebApp.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}