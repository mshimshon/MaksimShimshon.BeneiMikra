using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Stores;
[FeatureState]
public record BrachaViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public BrachaResponse? Result { get; set; }
}
