using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Reducers;
internal class TanakhGetOneChapiterResultReducer : Reducer<TanakhViewState, TanakhGetOnChapiterResultAction>
{
    public override TanakhViewState Reduce(TanakhViewState state, TanakhGetOnChapiterResultAction action)
        => state with { Chapiter = action.Result, IsLoading = action.IsLoading };
}
