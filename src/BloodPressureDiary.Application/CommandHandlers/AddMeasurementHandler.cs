namespace BloodPressureDiary.Application.CommandHandlers;

using BloodPressureDiary.Application.Commands;
using BloodPressureDiary.Application.Events;
using BloodPressureDiary.Domain.Entities;
using BloodPressureDiary.Domain.Interfaces;

internal sealed class AddMeasurementHandler : IRequestHandler<AddMeasurement>
{
    private readonly IDateTimeService dateTimeService;
    private readonly ILogger<AddMeasurementHandler> logger;
    private readonly IMediator mediator;
    private readonly IMeasurementRepository repository;

    public AddMeasurementHandler(IDateTimeService dateTimeService, ILogger<AddMeasurementHandler> logger, IMediator mediator, IMeasurementRepository repository)
        => (this.dateTimeService, this.logger, this.mediator, this.repository) = (dateTimeService, logger, mediator, repository);

    public async Task<Unit> Handle(AddMeasurement request, CancellationToken cancellationToken)
    {
        this.logger.LogInformation("Processing {Id} measurement", request.Id);

        // var dateTime = this.dateTimeService.GetNow();

        // var entity = new MeasurementEntity
        // {
        //     Id = request.Id,
        //     DateTime = dateTime,
        //     Diastolic = request.Diastolic,
        //     Systolic = request.Systolic,
        // };

        // await this.repository.Add(entity, cancellationToken);

        var notification = new AddedMeasurement
        {
            Id = request.Id,
        };

        await this.mediator.Publish(notification, cancellationToken);

        return await Task.FromResult(Unit.Value);
    }
}
