using MaksimShimshon.BneiMikra.App.Shared.Domain.Articles.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Queries;
public record GetManyArticlesQuery : IRequest<SearchResultEntity<ArticleEntity>>
{
}
