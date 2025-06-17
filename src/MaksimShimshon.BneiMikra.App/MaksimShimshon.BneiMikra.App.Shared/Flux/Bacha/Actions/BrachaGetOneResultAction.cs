using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
public record BrachaGetOneResultAction
{
    public bool IsLoading { get; set; }

    public BrachaResponse? Result { get; set; }
}
