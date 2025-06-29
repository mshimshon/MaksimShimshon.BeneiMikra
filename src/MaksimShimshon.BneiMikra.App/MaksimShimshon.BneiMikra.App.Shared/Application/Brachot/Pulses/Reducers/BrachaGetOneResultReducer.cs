using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Reducers;
internal class BrachaGetOneResultReducer : IReducer<BrachaViewState, BrachaGetOneResultAction>
{
    public Task<BrachaViewState> ReduceAsync(BrachaViewState state, BrachaGetOneResultAction action)
        => Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
