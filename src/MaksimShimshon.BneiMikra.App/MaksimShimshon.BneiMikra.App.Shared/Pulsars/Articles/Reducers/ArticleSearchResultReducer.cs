using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Reducers;
internal class ArticleSearchResultReducer : IReducer<ArticleSearchState, ArticleSearchResultAction>
{
    public Task<ArticleSearchState> ReduceAsync(ArticleSearchState state, ArticleSearchResultAction action)
        => Task.FromResult(state with { Result = action.Result, IsLoading = action.IsLoading });
}
