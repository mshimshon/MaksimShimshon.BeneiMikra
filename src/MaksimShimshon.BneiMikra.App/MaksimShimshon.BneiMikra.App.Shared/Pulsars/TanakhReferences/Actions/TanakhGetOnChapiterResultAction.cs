using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Actions;
public record TanakhGetOnChapiterResultAction : IAction
{
    public bool IsLoading { get; set; }
    public List<TanakhVerseResponse>? Result { get; set; }
}
