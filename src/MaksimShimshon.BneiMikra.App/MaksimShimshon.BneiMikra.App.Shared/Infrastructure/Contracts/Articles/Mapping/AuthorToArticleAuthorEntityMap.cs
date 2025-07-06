using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class AuthorToArticleAuthorEntityMap : ICoreMapHandler<AuthorLiteResponse, ArticleAuthorDetailsEntity>
{
    public ArticleAuthorDetailsEntity Handler(AuthorLiteResponse data) => new ArticleAuthorDetailsEntity()
    {
        Id = data.DocumentId,
        Name = data.Name,
    };

    public async Task<ArticleAuthorDetailsEntity> HandlerAsync(AuthorLiteResponse data)
        => await Task.FromResult(Handler(data));
}
