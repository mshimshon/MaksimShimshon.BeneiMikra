using CoreMap;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class ArticleToEntity : ICoreMapHandler<ArticleResponse, ArticleToEntity>
{
    public ArticleToEntity()
    {

    }
    public ArticleToEntity MapHandler(ArticleResponse data) => throw new NotImplementedException();
    public async Task<ArticleToEntity> MapHandlerAsync(ArticleResponse data)
        => await Task.FromResult(MapHandler(data));
}
