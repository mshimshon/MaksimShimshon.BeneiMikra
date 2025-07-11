using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Stores;
public record BrachaViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public BrachaEntity? Result { get; set; }
}
