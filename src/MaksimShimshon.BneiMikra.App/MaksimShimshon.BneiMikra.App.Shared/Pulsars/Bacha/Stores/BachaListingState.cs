using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Stores;

[FeatureState]
public record BrachaListingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
