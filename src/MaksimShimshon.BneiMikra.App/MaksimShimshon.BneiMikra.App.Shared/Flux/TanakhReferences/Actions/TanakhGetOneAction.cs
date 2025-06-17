namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
public record TanakhGetOneAction(string Book, int Chapiter)
{
    public int? Verse { get; set; }
}
