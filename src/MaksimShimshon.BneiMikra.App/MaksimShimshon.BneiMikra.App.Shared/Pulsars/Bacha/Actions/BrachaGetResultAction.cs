using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
public record BrachaGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
