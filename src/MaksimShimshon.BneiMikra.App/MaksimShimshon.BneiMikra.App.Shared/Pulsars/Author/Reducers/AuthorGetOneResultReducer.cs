using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Reducers;
internal class AuthorGetOneResultReducer : IReducer<AuthorViewState, AuthorGetOneResultAction>
{
    public async Task<AuthorViewState> ReduceAsync(AuthorViewState state, AuthorGetOneResultAction action)
        => await Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
