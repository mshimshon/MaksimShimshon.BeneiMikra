using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Stores;
[FeatureState]
public record BrachaViewState
{
    public bool IsLoading { get; set; }
    public BrachaResponse? Result { get; set; }
}
