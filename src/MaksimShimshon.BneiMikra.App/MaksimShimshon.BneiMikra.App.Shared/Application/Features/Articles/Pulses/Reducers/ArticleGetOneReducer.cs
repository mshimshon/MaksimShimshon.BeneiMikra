using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Reducers;
internal class ArticleGetOneReducer : IReducer<ArticleViewState, ArticleGetOneResultAction>
{

    public async Task<ArticleViewState> ReduceAsync(ArticleViewState state, ArticleGetOneResultAction action)
        => await Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
