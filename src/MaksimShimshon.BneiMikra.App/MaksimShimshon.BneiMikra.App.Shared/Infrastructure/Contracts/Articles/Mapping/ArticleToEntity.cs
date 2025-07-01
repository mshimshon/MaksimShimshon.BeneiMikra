using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class ArticleToEntity : ICoreMapHandler<ArticleResponse, ArticleEntity>
{
    public ArticleToEntity()
    {

    }
    public ArticleEntity MapHandler(ArticleResponse data) => new()
    {

    };

    public async Task<ArticleEntity> MapHandlerAsync(ArticleResponse data)
        => await Task.FromResult(MapHandler(data));
}
