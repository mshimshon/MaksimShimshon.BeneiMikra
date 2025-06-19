global using Fluxor;
global using MaksimShimshon.BneiMikra.App.Shared.Extensions;
global using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
global using MaksimShimshon.BneiMikra.App.Shared.Resources;
global using MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
global using MaksimShimshon.BneiMikra.App.Shared.Utils;
global using MudBlazor;
global using MudBlazor.Services;
global using System.Net.Http.Json;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Mapping;
using MaksimShimshon.BneiMikra.App.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared;
public static class ServiceRegisterExt
{
    public static void AddUIServices(this IServiceCollection serviceDescriptors)
    {
        serviceDescriptors.AddMudServices(ConfigureMudService);
        serviceDescriptors.AddMudMarkdownServices();
        serviceDescriptors.AddScoped<IResourceProvider<ApplicationResource>, ResourceProvider<ApplicationResource>>();
        serviceDescriptors.AddScoped<IDispatcherClient, DispatcherClient>();
        serviceDescriptors.AddSingleton<ITransliterationProvider, TrasliterationProvider>();
        serviceDescriptors.AddScoped<IJSProvider, JavaScriptProvider>();
        serviceDescriptors.AddScoped<IEnvironmentProvider, EnvironmentProvider>();
        serviceDescriptors.AddScoped<ILocalStorageProvider, LocalStorageProvider>();
        serviceDescriptors.AddScoped<IStartupProvider, StartupProvider>();
        serviceDescriptors.AddScoped<IHttpClientProvider, HttpClientProvider>();
        GlobalJsonOptions.RegisterCustomConverters(o =>
        {
            o.Add(new BlockResponseJsonConverter());
        });

        GlobalJsonOptions.SetupGlobalBehavior(o =>
        {
            o.PropertyNameCaseInsensitive = true;
            o.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });
        //serviceDescriptors.RegisterProtocolLinks();
        serviceDescriptors.AddFluxor(options =>
        {
            options.ScanAssemblies(typeof(ServiceRegisterExt).Assembly);
#if DEBUG
            //options.UseReduxDevTools(opt =>
            //{

            //    opt.Name = "My application";
            //    opt.EnableStackTrace();
            //});
#endif
        });
        // Register Protocol Commands
        //serviceDescriptors.AddScoped<ILinkProtocolHandler<AuthenticatedRequest>, AuthenticatedHandler>();
        serviceDescriptors.AddHttpClient();
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
