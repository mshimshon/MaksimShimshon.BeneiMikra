using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Reducers;
internal class ArticleSearchResultReducer : Reducer<ArticleSearchState, ArticleSearchResultAction>
{
    public override ArticleSearchState Reduce(ArticleSearchState state, ArticleSearchResultAction action)
    => state with
    {
        IsLoading = action.IsLoading,
        Result = action.Result
    };

}
