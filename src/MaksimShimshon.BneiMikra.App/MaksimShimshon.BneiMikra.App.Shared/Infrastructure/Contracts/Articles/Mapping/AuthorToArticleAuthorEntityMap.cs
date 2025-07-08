using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles.Mapping;
internal class AuthorToArticleAuthorEntityMap : ICoreMapHandler<AuthorLiteResponse, ArticleAuthorDetailsEntity>
{
    public ArticleAuthorDetailsEntity Handler(AuthorLiteResponse data, ICoreMap alsoMap) => new ArticleAuthorDetailsEntity()
    {
        Id = data.DocumentId,
        Name = data.Name,
    };

}
