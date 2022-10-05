namespace BloodPressureDiary.Domain.Entities;

public class MeasurementEntity
{
    public Guid Id { get; set; } = Guid.Empty;
    public DateTime DateTime { get; set; } = default;
    public int Systolic { get; set; } = default;
    public int Diastolic { get; set; } = default;
}
