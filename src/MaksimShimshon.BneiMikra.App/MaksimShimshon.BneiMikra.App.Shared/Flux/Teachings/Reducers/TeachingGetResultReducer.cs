using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Reducers;
internal class TeachingGetResultReducer : Reducer<TeachingState, TeachingGetResultAction>
{
    public override TeachingState Reduce(TeachingState state, TeachingGetResultAction action)
        => state with
        {
            IsLoading = action.IsLoading,
            Teachings = action.Result
        };
}
