using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Reducers;
internal class BrachaGetOneResultReducer : IReducer<BrachaViewState, BrachaGetOneResultAction>
{
    public Task<BrachaViewState> ReduceAsync(BrachaViewState state, BrachaGetOneResultAction action)
        => Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
