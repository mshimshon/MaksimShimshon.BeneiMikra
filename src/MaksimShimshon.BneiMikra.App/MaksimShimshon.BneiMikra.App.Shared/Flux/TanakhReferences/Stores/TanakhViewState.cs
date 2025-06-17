using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Stores;
[FeatureState]
public record TanakhViewState
{
    public bool IsLoading { get; set; }
    public TanakhVerseResponse? Verse { get; set; }
    public List<TanakhVerseResponse>? Chapiter { get; set; }
}
