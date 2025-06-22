using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Reducers;
internal class TeachingGetResultReducer : IReducer<TeachingState, TeachingGetResultAction>
{
    public Task<TeachingState> ReduceAsync(TeachingState state, TeachingGetResultAction action)
        => Task.FromResult(state with
        {
            IsLoading = action.IsLoading,
            Teachings = action.Result
        });
}
