using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
using Strapi.Net;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class ArticleReadRepository : IArticleReadRepository
{
    private readonly IStrapiClient _stapiClient;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;
    private readonly ICoreMap _coreMap;

    public ArticleReadRepository(
        IStrapiClient stapiClient,
        IResourceProvider<ApplicationResource> appResourceProvider,
        ICoreMap coreMap)
    {
        _stapiClient = stapiClient;
        _appResourceProvider = appResourceProvider;
        _coreMap = coreMap;
    }
    public async Task<ArticleEntity> GetById(string id)
    {
        var article = await _stapiClient.GetAsync<ArticleResponse>($"articles/{id}");
        if (article == default)
            throw new AppUnknownException("ApiUnknownException", _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        if (article.Error != default)
            throw new AppApiException(new ValidationErrorEntity() { Code = article.Error.Name, Message = article.Error.Message });
        if (article.Data != default)
        {
            await _coreMap.MapToAsync<ArticleEntity, ArticleResponse>(article.Data);
        }
    }

    public Task<SearchResultEntity<ArticleEntity>> GetMany(string? keywords, string? category, string? sortBy, int page = 1)
        => throw new NotImplementedException();
}
