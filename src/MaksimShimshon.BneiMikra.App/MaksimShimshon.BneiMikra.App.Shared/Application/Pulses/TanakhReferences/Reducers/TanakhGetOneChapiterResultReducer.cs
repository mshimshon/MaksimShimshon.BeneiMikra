using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Reducers;
internal class TanakhGetOneChapiterResultReducer : IReducer<TanakhViewState, TanakhGetOnChapiterResultAction>
{
    public Task<TanakhViewState> ReduceAsync(TanakhViewState state, TanakhGetOnChapiterResultAction action)
        => Task.FromResult(state with
        {
            Chapiter = action.Result,
            IsLoading = action.IsLoading
        });
}
