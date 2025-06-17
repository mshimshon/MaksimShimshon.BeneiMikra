using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
public record BrachaGetResultAction
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
