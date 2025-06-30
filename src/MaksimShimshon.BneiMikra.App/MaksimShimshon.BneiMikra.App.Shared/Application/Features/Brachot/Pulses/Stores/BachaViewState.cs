using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Stores;
[FeatureState]
public record BrachaViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public BrachaResponse? Result { get; set; }
}
