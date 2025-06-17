using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Stores;

[FeatureState]
public record BrachaListingState
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
