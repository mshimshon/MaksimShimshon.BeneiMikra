using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Queries;
public record GetArticleQuery(string Id) : IRequest<ArticleEntity>
{
}
