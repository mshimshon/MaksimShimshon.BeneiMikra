using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Reducers;
internal class ArticleGetOneReducer : IReducer<ArticleViewState, ArticleGetOneResultAction>
{

    public async Task<ArticleViewState> ReduceAsync(ArticleViewState state, ArticleGetOneResultAction action)
        => await Task.FromResult(state with { IsLoading = action.IsLoading, Result = action.Result });
}
