using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;

public record ArticleSearchState : IStateFeature
{
    public bool IsLoading { get; set; }
    public SearchResultEntity<ArticleEntity>? Result { get; set; }
}
