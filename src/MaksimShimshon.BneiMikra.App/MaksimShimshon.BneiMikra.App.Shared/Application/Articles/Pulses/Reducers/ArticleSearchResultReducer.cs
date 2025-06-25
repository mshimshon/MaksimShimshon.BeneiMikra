using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Reducers;
internal class ArticleSearchResultReducer : IReducer<ArticleSearchState, ArticleSearchResultAction>
{
    public Task<ArticleSearchState> ReduceAsync(ArticleSearchState state, ArticleSearchResultAction action)
        => Task.FromResult(state with { Result = action.Result, IsLoading = action.IsLoading });
}
