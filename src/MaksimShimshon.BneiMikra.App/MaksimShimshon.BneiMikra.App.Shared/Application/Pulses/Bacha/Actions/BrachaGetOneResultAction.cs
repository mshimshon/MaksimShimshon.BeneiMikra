using MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Actions;
public record BrachaGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }

    public BrachaResponse? Result { get; set; }
}
