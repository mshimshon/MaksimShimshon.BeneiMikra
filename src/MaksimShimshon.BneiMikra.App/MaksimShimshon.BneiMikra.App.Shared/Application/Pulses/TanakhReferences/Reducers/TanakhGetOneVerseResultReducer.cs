using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.TanakhReferences.Reducers;
internal class TanakhGetOneVerseResultReducer : IReducer<TanakhViewState, TanakhGetOneVerseResultAction>
{
    public Task<TanakhViewState> ReduceAsync(TanakhViewState state, TanakhGetOneVerseResultAction action)
        => Task.FromResult(state with
        {
            IsLoading = action.IsLoading,
            Verse = action.Result
        });
}
