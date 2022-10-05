namespace BloodPressureDiary.Infrastructure.Services;

using BloodPressureDiary.Domain.Entities;
using BloodPressureDiary.Domain.Interfaces;

internal sealed class MeasurementRepository : IMeasurementRepository
{
    public Task Add(MeasurementEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
