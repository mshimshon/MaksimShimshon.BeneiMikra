using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Reducers;
internal class BrachaGetResultReducer : IReducer<BrachaListingState, BrachaGetResultAction>
{
    public Task<BrachaListingState> ReduceAsync(BrachaListingState state, BrachaGetResultAction action)
        => Task.FromResult(state with { Result = action.Result, IsLoading = action.IsLoading });

}
