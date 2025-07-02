using MaksimShimshon.BneiMikra.App.Shared.Application;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;
using Microsoft.Extensions.DependencyInjection;
using Strapi.Net;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure;
public static class RegisterInfrastructionServicesExt
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
    {
        services.AddStrapi();
        services.AddHttpClient();

        services.AddSingleton<IEnvironmentProvider, EnvironmentProvider>();
        services.AddScoped<ILocalStorageProvider, LocalStorageProvider>();
        services.AddScoped<IResourceProvider<ApplicationResource>, ResourceProvider<ApplicationResource>>();
        services.AddScoped<IStrapiClient, StrapiClient>();
        services.AddApplicationServices();
        return services;
    }
}
