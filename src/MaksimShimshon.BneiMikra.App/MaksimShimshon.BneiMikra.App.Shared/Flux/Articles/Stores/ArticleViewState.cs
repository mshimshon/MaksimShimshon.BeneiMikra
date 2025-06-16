using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;

[FeatureState]
public record ArticleViewState
{
    public bool IsLoading { get; set; }
    public ArticleResponse? Result { get; set; }
}
