using MaksimShimshon.BneiMikra.App.Shared.Presentation.Articles.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Authors.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Brachot.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Home.ViewModels;
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
        return services;
    }
}
