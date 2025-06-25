using MaksimShimshon.BneiMikra.App.Shared.Contracts.TanakhReferences.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Actions;
public record TanakhGetOneVerseResultAction : IAction
{
    public bool IsLoading { get; set; }
    public TanakhVerseResponse? Result { get; set; }
}
