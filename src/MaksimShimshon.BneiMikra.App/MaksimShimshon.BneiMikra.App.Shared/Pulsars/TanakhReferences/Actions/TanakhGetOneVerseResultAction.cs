using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Actions;
public record TanakhGetOneVerseResultAction : IAction
{
    public bool IsLoading { get; set; }
    public TanakhVerseResponse? Result { get; set; }
}
