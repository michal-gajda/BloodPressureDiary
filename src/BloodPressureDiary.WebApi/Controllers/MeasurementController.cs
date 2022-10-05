namespace BloodPressureDiary.WebApi.Controllers;

using BloodPressureDiary.Application.Commands;
using Microsoft.AspNetCore.Mvc;

[ApiController, Route("[controller]")]
public sealed class MeasurementController : ControllerBase
{
    private readonly ILogger<MeasurementController> logger;
    private readonly IMediator mediator;

    public MeasurementController(ILogger<MeasurementController> logger, IMediator mediator)
        => (this.logger, this.mediator) = (logger, mediator);

    [HttpPost(Name = "Add")]
    public async Task<IActionResult> AddAsync(AddMeasurement measurement, CancellationToken cancellationToken = default)
    {
        this.logger.LogInformation("Add {Id} measurement", measurement.Id);

        _ = await this.mediator.Send(measurement, cancellationToken);

        return await Task.FromResult(this.Ok());
    }
}
