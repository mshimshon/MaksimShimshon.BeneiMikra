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
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class ArticleReadRepository : IArticleReadRepository
{
    private readonly IStrapiClient _strapiClient;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;
    private readonly ICoreMap _coreMap;

    public ArticleReadRepository(
        IStrapiClient strapiClient,
        IResourceProvider<ApplicationResource> appResourceProvider,
        ICoreMap coreMap)
    {
        _strapiClient = strapiClient;
        _appResourceProvider = appResourceProvider;
        _coreMap = coreMap;
    }
    public async Task<ArticleEntity?> GetById(string id)
    {
        var article = await _strapiClient.GetAsync<ArticleResponse>($"articles/{id}");
        if (article == default)
            throw new AppUnknownException("ApiUnknownException", _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        if (article.Error != default)
            throw new AppApiException(new ValidationErrorEntity() { Code = article.Error.Name, Message = article.Error.Message });
        if (article.Data != default)
        {
            return await _coreMap.MapToAsync<ArticleResponse, ArticleEntity>(article.Data.First());
        }
        return default;
    }

    public async Task<SearchResultEntity<ArticleEntity>?> GetMany(string? keywords, string? category, string? sortBy, int page = 1)
    {
        var query = StrapiQueryBuilder.Create();

        query.Filter<ArticleResponse>(p => p.Category!, Strapi.Net.Enums.StrapiFilterOperator.IsNull, "false");

        if (!string.IsNullOrWhiteSpace(category))
            query.Filter<ArticleResponse>(p => p.Category!, Strapi.Net.Enums.StrapiFilterOperator.Equal, category);

        if (!string.IsNullOrWhiteSpace(sortBy))
            query.AddSort(sortBy);

        query.Paginate(page, 10);
        if (!string.IsNullOrWhiteSpace(keywords))
            query.Search(keywords);
        string url = query.ToQueryString("articles");
        var result = await _strapiClient.GetAsync<ArticleResponse>(url);
        if (result == default)
            throw new AppUnknownException("ApiUnknownException", _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        if (result.Error != default)
            throw new AppApiException(new ValidationErrorEntity()
            {
                Code = result.Error.Name,
                Message = result.Error.Message
            });

        if (result.Data != default)
        {
            return await _coreMap.MapToAsync<StrapiResponse<ArticleResponse>, SearchResultEntity<ArticleEntity>>(result);
        }
        return default;
    }
}
