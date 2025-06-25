namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Actions;
public record TanakhGetOneAction(string Book, int Chapiter) : IAction
{
    public int? Verse { get; set; }
}
