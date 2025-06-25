using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi;
public static class RegisterServicesExt
{
    public static IServiceCollection AddStrapi(this IServiceCollection services)
    {
        services.AddTransient<IStrapiBuilder, StrapiQueryBuilder>();
        return services;
    }
}
