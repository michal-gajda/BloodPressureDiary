namespace BloodPressureDiary.Infrastructure;

using System.Reflection;
using BloodPressureDiary.Domain.Interfaces;
using BloodPressureDiary.Infrastructure.Services;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddSingleton<IDateTimeService, DateTimeService>();
        services.AddSingleton<IMeasurementRepository, MeasurementRepository>();
    }
}
