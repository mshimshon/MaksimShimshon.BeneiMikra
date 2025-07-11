using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class SearchArticleToEntity : ICoreMapHandler<StrapiResponse<ArticleResponse>, SearchResultEntity<ArticleEntity>>
{
    public SearchResultEntity<ArticleEntity> Handler(StrapiResponse<ArticleResponse> data, ICoreMap alsoMap)
        => new SearchResultEntity<ArticleEntity>()
        {
            Entities = alsoMap.MapEachTo<ArticleResponse, ArticleEntity>(data.Data),
            Page = data.Meta?.Pagination?.Page ?? 1,
            TotalPage = data.Meta?.Pagination?.Total ?? 1
        };
}
