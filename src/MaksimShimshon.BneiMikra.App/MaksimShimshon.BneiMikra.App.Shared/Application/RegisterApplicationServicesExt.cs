using CoreMap;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimShimshon.BneiMikra.App.Shared.Application;
public static class RegisterApplicationServicesExt
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegisterExt).Assembly));
        services.AddCoreMap();

        return services;
    }
}
