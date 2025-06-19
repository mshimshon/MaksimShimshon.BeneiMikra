using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Reducers;
internal class AuthorGetOneResultReducer : Reducer<AuthorViewState, AuthorGetOneResultAction>
{
    public override AuthorViewState Reduce(AuthorViewState state, AuthorGetOneResultAction action)
        => state with { IsLoading = action.IsLoading, Result = action.Result };
}
