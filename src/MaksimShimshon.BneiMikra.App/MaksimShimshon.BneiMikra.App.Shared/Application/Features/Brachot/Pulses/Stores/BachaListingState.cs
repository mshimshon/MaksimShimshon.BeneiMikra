using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Stores;

public record BrachaListingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public SearchResultEntity<BrachaEntity>? Result { get; set; }
}
