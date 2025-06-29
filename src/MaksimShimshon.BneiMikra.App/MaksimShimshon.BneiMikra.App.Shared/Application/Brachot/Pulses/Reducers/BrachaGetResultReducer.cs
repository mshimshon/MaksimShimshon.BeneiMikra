using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Reducers;
internal class BrachaGetResultReducer : IReducer<BrachaListingState, BrachaGetResultAction>
{
    public Task<BrachaListingState> ReduceAsync(BrachaListingState state, BrachaGetResultAction action)
        => Task.FromResult(state with { Result = action.Result, IsLoading = action.IsLoading });

}
