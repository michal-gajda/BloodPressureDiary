namespace BloodPressureDiary.Application.Commands;

public sealed record AddMeasurement : IRequest
{
    public Guid Id { get; set; } = Guid.Empty;
    public int Systolic { get; set; } = default;
    public int Diastolic { get; set; } = default;
}
