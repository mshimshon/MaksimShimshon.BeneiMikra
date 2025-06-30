using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries;
public record GetArticleQuery(string Id) : IRequest<ArticleEntity>
{
}
