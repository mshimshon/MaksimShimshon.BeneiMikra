global using MediatR;
global using MudBlazor;
global using MudBlazor.Services;
global using StatePulse.Net;
global using SwizzleV;
using MaksimShimshon.BneiMikra.App.Shared.Application;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure;
using MaksimShimshon.BneiMikra.App.Shared.Presentation;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
namespace MaksimShimshon.BneiMikra.App.Shared;
public static class ServiceRegisterExt
{
    public static void AddUIServices(this IServiceCollection services)
    {

        services.AddMudServices(ConfigureMudService);
        services.AddMudMarkdownServices();
        services.AddMapster();

        services.AddApplicationServices();
        services.AddInfrastructureService();
        services.AddPresentationServices();

        services.AddStatePulseServices(o =>
        {
            o.ScanAssemblies = new Type[] { typeof(ServiceRegisterExt) };
        });
        services.AddHttpClient();
    }
    private static void ConfigureMudService(MudServicesConfiguration config)
    {
        config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
        config.SnackbarConfiguration.PreventDuplicates = true;
        config.SnackbarConfiguration.NewestOnTop = false;
        config.SnackbarConfiguration.ShowCloseIcon = true;
        config.SnackbarConfiguration.VisibleStateDuration = 5000;
        config.SnackbarConfiguration.HideTransitionDuration = 500;
        config.SnackbarConfiguration.ShowTransitionDuration = 500;
        config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
    }
}
