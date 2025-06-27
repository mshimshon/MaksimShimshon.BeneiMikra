using MaksimShimshon.BneiMikra.App.Shared.Domain.Articles.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Queries;
public record GetArticleQuery(string Id) : IRequest<ArticleEntity>
{
}
