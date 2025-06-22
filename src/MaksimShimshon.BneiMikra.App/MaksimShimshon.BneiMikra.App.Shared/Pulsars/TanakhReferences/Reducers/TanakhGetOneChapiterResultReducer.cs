using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Reducers;
internal class TanakhGetOneChapiterResultReducer : IReducer<TanakhViewState, TanakhGetOnChapiterResultAction>
{
    public Task<TanakhViewState> ReduceAsync(TanakhViewState state, TanakhGetOnChapiterResultAction action)
        => Task.FromResult(state with
        {
            Chapiter = action.Result,
            IsLoading = action.IsLoading
        });
}
