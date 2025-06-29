global using MediatR;
global using MudBlazor;
global using MudBlazor.Services;
global using StatePulse.Net;
global using SwizzleV;
global using System.Net.Http.Json;
using MaksimShimshon.BneiMikra.App.Shared.Application;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure;
using MaksimShimshon.BneiMikra.App.Shared.Presentation;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Articles.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Utils;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
namespace MaksimShimshon.BneiMikra.App.Shared;
public static class ServiceRegisterExt
{
    public static void AddUIServices(this IServiceCollection services)
    {
        GlobalJsonOptions.RegisterCustomConverters(o =>
        {
            o.Add(new BlockResponseJsonConverter());
        });

        services.AddMudServices(ConfigureMudService);
        services.AddMudMarkdownServices();
        services.AddScoped<IResourceProvider<ApplicationResource>, ResourceProvider<ApplicationResource>>();
        services.AddScoped<IDispatcherClient, DispatcherClient>();
        services.AddSingleton<ITransliterationProvider, TrasliterationProvider>();
        services.AddScoped<IJSProvider, JavaScriptProvider>();
        services.AddScoped<IEnvironmentProvider, EnvironmentProvider>();
        services.AddScoped<ILocalStorageProvider, LocalStorageProvider>();
        services.AddScoped<IStartupProvider, StartupProvider>();
        services.AddScoped<IHttpClientProvider, HttpClientProvider>();
        services.AddScoped<ArticleViewModel>()
        //services.AddStrapi();
        services.AddMapster();
        services.AddApplicationServices();
        services.AddInfrastructureService();
        services.AddPresentationServices();
        GlobalJsonOptions.SetupGlobalBehavior(o =>
        {
            o.PropertyNameCaseInsensitive = true;
            o.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });
        //serviceDescriptors.RegisterProtocolLinks();

        services.AddStatePulseServices(o =>
        {
            o.ScanAssemblies = new Type[] { typeof(ServiceRegisterExt) };
        });

        // Register Protocol Commands
        //serviceDescriptors.AddScoped<ILinkProtocolHandler<AuthenticatedRequest>, AuthenticatedHandler>();
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
