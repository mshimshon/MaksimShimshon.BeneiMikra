using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Reducers;
internal class TeachingGetResultReducer : IReducer<TeachingState, TeachingGetResultAction>
{
    public Task<TeachingState> ReduceAsync(TeachingState state, TeachingGetResultAction action)
        => Task.FromResult(state with
        {
            IsLoading = action.IsLoading,
            Result = action.Result
        });
}
