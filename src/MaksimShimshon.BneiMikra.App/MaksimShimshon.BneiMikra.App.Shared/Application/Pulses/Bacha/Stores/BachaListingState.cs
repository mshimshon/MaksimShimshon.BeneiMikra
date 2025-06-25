using MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Stores;

[FeatureState]
public record BrachaListingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
