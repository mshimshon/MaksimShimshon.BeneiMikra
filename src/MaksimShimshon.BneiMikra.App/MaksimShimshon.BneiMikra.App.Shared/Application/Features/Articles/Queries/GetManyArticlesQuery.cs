using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries;
public record GetManyArticlesQuery : IRequest<SearchResultEntity<ArticleEntity>>
{
    public string? Keywords { get; init; }
    public string? Categories { get; init; }
    public int Page { get; init; } = 1;

}
