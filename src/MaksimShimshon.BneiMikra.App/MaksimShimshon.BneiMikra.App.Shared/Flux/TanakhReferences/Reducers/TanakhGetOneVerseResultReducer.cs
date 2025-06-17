using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Reducers;
internal class TanakhGetOneVerseResultReducer : Reducer<TanakhViewState, TanakhGetOneVerseResultAction>
{
    public override TanakhViewState Reduce(TanakhViewState state, TanakhGetOneVerseResultAction action)
        => state with
        {
            IsLoading = action.IsLoading,
            Verse = action.Result
        };
}
