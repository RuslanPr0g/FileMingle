using Microsoft.Extensions.DependencyInjection;

namespace FM.Integration.Extensions;

public static class IntegrationExtensions
{
    public static IServiceCollection AddIntegration(this IServiceCollection services)
    {
        services.AddScoped<IFileClient, FileClient>();
        return services;
    }
}