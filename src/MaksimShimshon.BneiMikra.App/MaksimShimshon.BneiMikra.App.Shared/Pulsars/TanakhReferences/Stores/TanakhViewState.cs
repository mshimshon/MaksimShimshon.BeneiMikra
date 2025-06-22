using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Stores;
public record TanakhViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public TanakhVerseResponse? Verse { get; set; }
    public List<TanakhVerseResponse>? Chapiter { get; set; }
}
