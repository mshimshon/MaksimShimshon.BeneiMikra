using MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Reducers;
internal class BrachaGetResultReducer : Reducer<BrachaListingState, BrachaGetResultAction>
{
    public override BrachaListingState Reduce(BrachaListingState state, BrachaGetResultAction action)
        => state with
        {
            IsLoading = action.IsLoading,
            Result = action.Result
        };
}
