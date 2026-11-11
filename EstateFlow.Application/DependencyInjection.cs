using EstateFlow.Application.Contracts.Properties;
using EstateFlow.Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EstateFlow.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreatePropertyRequestValidator>();
        services.AddScoped<IMeterReadingService, MeterReadingService>();

        return services;
    }
}
