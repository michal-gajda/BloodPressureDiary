namespace BloodPressureDiary.Infrastructure.Services;

using BloodPressureDiary.Domain.Interfaces;

internal sealed class DateTimeService : IDateTimeService
{
    public DateTime GetNow() => DateTime.UtcNow;
}
