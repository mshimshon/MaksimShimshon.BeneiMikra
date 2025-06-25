using MaksimShimshon.BneiMikra.App.Shared.Contracts.TanakhReferences.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Actions;
public record TanakhGetOnChapiterResultAction : IAction
{
    public bool IsLoading { get; set; }
    public List<TanakhVerseResponse>? Result { get; set; }
}
