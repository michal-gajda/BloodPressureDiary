namespace BloodPressureDiary.Domain.Interfaces;

using BloodPressureDiary.Domain.Entities;

public interface IMeasurementRepository
{
    Task Add(MeasurementEntity entity, CancellationToken cancellationToken = default);
}
