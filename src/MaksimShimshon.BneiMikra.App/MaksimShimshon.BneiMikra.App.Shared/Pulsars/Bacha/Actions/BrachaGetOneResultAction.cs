using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
public record BrachaGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }

    public BrachaResponse? Result { get; set; }
}
