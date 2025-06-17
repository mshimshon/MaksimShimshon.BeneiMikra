using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
public record TanakhGetOneVerseResultAction
{
    public bool IsLoading { get; set; }
    public TanakhVerseResponse? Result { get; set; }
}
