using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class ArticleToEntityMap : ICoreMapHandler<ArticleResponse, ArticleEntity>
{
    private readonly ICoreMap _coreMap;

    public ArticleToEntityMap(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }

    public ArticleEntity MapHandler(ArticleResponse data) => new()
    {
        Id = data.DocumentId,
        Description = data.Description,
        Title = data.Title,
        PublishedOn = data.PublishedAt,
        Categories = data.Category != default ? new()
        {
            data.Category.Slug
        } : new() { },
        LastRevision = data.UpdatedAt,
        Author = data.Author != default ? _coreMap.MapTo<AuthorLiteResponse, ArticleAuthorDetailsEntity>(data.Author) : default,
        Details = data.Blocks != default ? new()
        {
            BodyParts = data.Blocks.SkipWhile(p => !BlockMapper.Matches.ContainsKey(p.Component))
                .Select(p => BlockMapper.Matches[p.Component](_coreMap, p.RawContent)).ToList()
        } : default
    };

    public async Task<ArticleEntity> MapHandlerAsync(ArticleResponse data)
        => await Task.FromResult(MapHandler(data));


}
