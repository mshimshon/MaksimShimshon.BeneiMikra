using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Stores;

[FeatureState]
public record BrachaListingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
