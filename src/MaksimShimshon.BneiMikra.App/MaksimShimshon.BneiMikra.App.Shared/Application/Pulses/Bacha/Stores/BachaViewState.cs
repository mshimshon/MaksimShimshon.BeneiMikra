using MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Stores;
[FeatureState]
public record BrachaViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public BrachaResponse? Result { get; set; }
}
