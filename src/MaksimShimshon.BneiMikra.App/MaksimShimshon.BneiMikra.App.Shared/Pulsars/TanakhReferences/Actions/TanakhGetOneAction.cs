namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Actions;
public record TanakhGetOneAction(string Book, int Chapiter) : IAction
{
    public int? Verse { get; set; }
}
