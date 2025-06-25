using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Reducers;
internal class TeachingGetResultReducer : IReducer<TeachingState, TeachingGetResultAction>
{
    public Task<TeachingState> ReduceAsync(TeachingState state, TeachingGetResultAction action)
        => Task.FromResult(state with
        {
            IsLoading = action.IsLoading,
            Teachings = action.Result
        });
}
