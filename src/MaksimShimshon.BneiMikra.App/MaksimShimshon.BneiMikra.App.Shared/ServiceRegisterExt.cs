global using Fluxor;
global using MudBlazor;
global using MudBlazor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimShimshon.BneiMikra.App.Shared;
public static class ServiceRegisterExt
{
    public static void AddUIServices(this IServiceCollection serviceDescriptors)
    {
        serviceDescriptors.AddMudServices(ConfigureMudService);
        //        serviceDescriptors.AddScoped<IResourceProvider<AuthenticationResource>, GenericResourceProvider<AuthenticationResource>>();
        //        serviceDescriptors.AddScoped<IResourceProvider<BetaWarningResource>, GenericResourceProvider<BetaWarningResource>>();
        //        serviceDescriptors.AddScoped<IResourceProvider<CodedExceptionsResource>, GenericResourceProvider<CodedExceptionsResource>>();
        //        serviceDescriptors.AddScoped<IResourceProvider<ApplicationResource>, GenericResourceProvider<ApplicationResource>>();
        //        serviceDescriptors.AddScoped<IResourceProvider<CustomIngredientResource>, GenericResourceProvider<CustomIngredientResource>>();
        //        serviceDescriptors.AddScoped<IResourceProvider<FormulationResource>, GenericResourceProvider<FormulationResource>>();
        //        serviceDescriptors.AddScoped<IDispatcherClient, DispatcherClient>();
        //        serviceDescriptors.AddScoped<IJSProvider, JavaScriptProvider>();
        //        serviceDescriptors.AddScoped<IEnvironmentProvider, EnvironmentProvider>();
        //        serviceDescriptors.AddScoped<ILocalStorageProvider, LocalStorageProvider>();
        //        serviceDescriptors.AddScoped<IStartupProvider, StartupProvider>();
        //        serviceDescriptors.AddScoped<IHttpClientProvider, HttpClientProvider>();
        //        serviceDescriptors.RegisterProtocolLinks();
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
