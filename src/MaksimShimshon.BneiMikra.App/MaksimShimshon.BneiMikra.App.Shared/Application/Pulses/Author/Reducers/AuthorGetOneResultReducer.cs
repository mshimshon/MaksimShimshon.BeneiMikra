using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Reducers;
internal class AuthorGetOneResultReducer : IReducer<AuthorViewState, AuthorGetOneResultAction>
{
    public async Task<AuthorViewState> ReduceAsync(AuthorViewState state, AuthorGetOneResultAction action)
        => await Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
