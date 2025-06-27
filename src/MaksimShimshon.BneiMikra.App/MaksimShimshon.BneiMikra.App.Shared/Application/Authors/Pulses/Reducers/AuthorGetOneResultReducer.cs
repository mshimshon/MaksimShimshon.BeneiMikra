using MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Reducers;
internal class AuthorGetOneResultReducer : IReducer<AuthorViewState, AuthorGetOneResultAction>
{
    public async Task<AuthorViewState> ReduceAsync(AuthorViewState state, AuthorGetOneResultAction action)
        => await Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
