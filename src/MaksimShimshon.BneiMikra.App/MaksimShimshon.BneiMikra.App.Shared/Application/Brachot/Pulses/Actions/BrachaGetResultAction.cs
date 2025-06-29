using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
public record BrachaGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public SearchResultEntity<BrachaEntity>? Result { get; set; }
}
