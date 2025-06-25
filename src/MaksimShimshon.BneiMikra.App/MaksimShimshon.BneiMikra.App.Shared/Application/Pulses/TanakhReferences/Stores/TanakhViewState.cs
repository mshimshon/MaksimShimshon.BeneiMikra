using MaksimShimshon.BneiMikra.App.Shared.Contracts.TanakhReferences.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Stores;
public record TanakhViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public TanakhVerseResponse? Verse { get; set; }
    public List<TanakhVerseResponse>? Chapiter { get; set; }
}
