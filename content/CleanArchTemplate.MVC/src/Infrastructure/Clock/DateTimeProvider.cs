using CleanArchTemplate.MVC.Application.Abstractions.Clock;

namespace CleanArchTemplate.MVC.Infrastructure.Clock;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}