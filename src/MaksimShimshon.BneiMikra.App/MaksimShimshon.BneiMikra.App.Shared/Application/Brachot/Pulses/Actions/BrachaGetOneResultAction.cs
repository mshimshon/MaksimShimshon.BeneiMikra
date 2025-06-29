using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
public record BrachaGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }

    public BrachaEntity? Result { get; set; }
}
