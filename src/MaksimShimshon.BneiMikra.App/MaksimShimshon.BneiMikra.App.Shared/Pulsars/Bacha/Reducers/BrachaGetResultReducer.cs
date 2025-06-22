using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Reducers;
internal class BrachaGetResultReducer : IReducer<BrachaListingState, BrachaGetResultAction>
{
    public Task<BrachaListingState> ReduceAsync(BrachaListingState state, BrachaGetResultAction action)
        => Task.FromResult(state with { Result = action.Result, IsLoading = action.IsLoading });

}
