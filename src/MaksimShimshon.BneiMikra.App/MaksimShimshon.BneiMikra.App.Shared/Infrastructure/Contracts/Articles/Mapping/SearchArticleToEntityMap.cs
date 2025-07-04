using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class SearchArticleToEntity : ICoreMapHandler<StrapiResponse<ArticleResponse>, SearchResultEntity<ArticleEntity>>
{
    private readonly ICoreMap _coreMap;

    public SearchArticleToEntity(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }
    public SearchResultEntity<ArticleEntity> MapHandler(StrapiResponse<ArticleResponse> data)
        => new SearchResultEntity<ArticleEntity>()
        {
            Entities = _coreMap.MapEachTo<ArticleResponse, ArticleEntity>(data.Data),
            Page = data.Meta?.Pagination?.Page ?? 1,
            TotalPage = data.Meta?.Pagination?.Total ?? 1
        };
    public async Task<SearchResultEntity<ArticleEntity>> MapHandlerAsync(StrapiResponse<ArticleResponse> data)
        => await Task.FromResult(MapHandler(data));
}
