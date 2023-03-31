using FM.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FM.Application.Extensions;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IFileService, FileService>();
        return services;
    }
}