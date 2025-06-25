using MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Actions;
public record BrachaGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public List<BrachaLiteResponse>? Result { get; set; }
}
