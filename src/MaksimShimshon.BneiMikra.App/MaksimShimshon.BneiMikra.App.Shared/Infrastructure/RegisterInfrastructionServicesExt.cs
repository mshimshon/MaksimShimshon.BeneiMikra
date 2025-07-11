using MaksimShimshon.BneiMikra.App.Shared.Application;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Tanakh.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
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

        services.AddApplicationServices();
        services.AddSingleton<IEnvironmentProvider, EnvironmentProvider>();
        services.AddScoped<ILocalStorageProvider, LocalStorageProvider>();
        services.AddScoped<IResourceProvider<ApplicationResource>, ResourceProvider<ApplicationResource>>();
        services.AddScoped<IArticleReadRepository, ArticleReadRepository>();
        services.AddScoped<IAuthorReadRepository, AuthorReadRepository>();
        services.AddScoped<IBrachaReadRepository, BrachaReadRepository>();
        services.AddScoped<ITanakhReadRepository, TanakhReadRepository>();
        services.AddScoped<ITeachingsReadRepository, TeachingReadRepository>();
        services.AddScoped<IAppSettingsReadRepository, AppSettingsReadRepository>();
        services.AddScoped<IStrapiClient, StrapiClient>();
        return services;
    }
}
