namespace BloodPressureDiary.Application.Events;

public sealed record AddedMeasurement : INotification
{
    public Guid Id { get; set; } = Guid.Empty;
}
