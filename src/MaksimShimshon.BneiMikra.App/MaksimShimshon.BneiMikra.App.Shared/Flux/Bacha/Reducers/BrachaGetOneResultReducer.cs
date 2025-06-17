using MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Reducers;
internal class BrachaGetOneResultReducer : Reducer<BrachaViewState, BrachaGetOneResultAction>
{
    public override BrachaViewState Reduce(BrachaViewState state, BrachaGetOneResultAction action)
        => state with { IsLoading = action.IsLoading, Result = action.Result };
}
