using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;

[FeatureState]
public record ArticleSearchState
{
    public bool IsLoading { get; set; }
    public SearchResultResponse<ArticleLiteResponse>? Result { get; set; }
}
