using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
public record TanakhGetOnChapiterResultAction
{
    public bool IsLoading { get; set; }
    public List<TanakhVerseResponse>? Result { get; set; }
}
