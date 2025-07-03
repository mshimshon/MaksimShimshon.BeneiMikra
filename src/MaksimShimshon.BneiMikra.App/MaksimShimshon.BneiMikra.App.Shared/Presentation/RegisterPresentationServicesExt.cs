using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Application;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Articles.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Authors.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Home.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Implementation;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Implementation.Transliterator;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation;
internal static class RegisterPresentationServicesExt
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddSwizzleV();
        services.AddScoped<AuthorViewModel>();
        services.AddScoped<ArticleViewModel>();
        services.AddScoped<BrachaViewModel>();
        services.AddScoped<BrachotViewModel>();
        services.AddScoped<MainMenuViewModel>();
        services.AddScoped<HomeViewModel>();
        services.AddScoped<AppTopBarViewModel>();
        services.AddTransient<HebrewSentenceViewModel>();
        services.AddTransient<TanakhReferenceViewModel>();
        services.AddTransient<BlockMarkdownViewModel>();
        services.AddScoped<IJavascriptProvider, JavascriptProvider>();
        services.AddScoped<ITransliterationProvider, TransliterationProvider>();
        services.AddCoreMap(o =>
        {
            o.Scope = CoreMap.Enums.ServiceScope.Scoped;
        }, new Type[] {
            typeof(RegisterInfrastructionServicesExt),
            typeof(RegisterPresentationServicesExt)
        });
        services.AddMudServices(ConfigureMudService);
        services.AddMudMarkdownServices();
        services.AddInfrastructureService();
        services.AddStatePulseServices(o =>
        {
            o.ScanAssemblies = new Type[] { typeof(RegisterPresentationServicesExt) };
            o.ScanAssemblies = new Type[] { typeof(RegisterApplicationServicesExt) };
        });
        return services;
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
