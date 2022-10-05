namespace BloodPressureDiary.Application.EventHandlers;

using BloodPressureDiary.Application.Events;

internal sealed class AddedMeasurementHandler : INotificationHandler<AddedMeasurement>
{
    private readonly ILogger<AddedMeasurementHandler> logger;

    public AddedMeasurementHandler(ILogger<AddedMeasurementHandler> logger)
        => (this.logger) = (logger);

    public Task Handle(AddedMeasurement notification, CancellationToken cancellationToken)
    {
        this.logger.LogInformation("Processed {Id} measurement", notification.Id);

        return Task.CompletedTask;
    }
}
