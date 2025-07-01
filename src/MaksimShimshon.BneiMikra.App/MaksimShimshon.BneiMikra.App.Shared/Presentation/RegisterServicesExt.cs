using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
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
internal static class RegisterServicesExt
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddSwizzleV();
        services.AddScoped<AuthorViewModel>();
        services.AddScoped<ArticleViewModel>();
        services.AddScoped<BrachaViewModel>();
        services.AddScoped<BrachotViewModel>();
        services.AddScoped<HomeViewModel>();
        services.AddScoped<AppTopBarViewModel>();
        services.AddTransient<HebrewSentenceViewModel>();
        services.AddTransient<TanakhReferenceViewModel>();

        services.AddScoped<IJavascriptProvider, JavascriptProvider>();
        services.AddScoped<ITransliterationProvider, TransliterationProvider>();

        services.AddMudServices();
        services.AddMudMarkdownServices();

        return services;
    }
}
