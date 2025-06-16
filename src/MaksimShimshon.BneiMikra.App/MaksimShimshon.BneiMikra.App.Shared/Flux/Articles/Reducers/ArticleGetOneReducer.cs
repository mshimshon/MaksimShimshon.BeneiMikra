using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Reducers;
internal class ArticleGetOneReducer : Reducer<ArticleViewState, ArticleGetOneResultAction>
{
    public override ArticleViewState Reduce(ArticleViewState state, ArticleGetOneResultAction action)
        => state with
        {
            IsLoading = action.IsLoading,
            Result = action.Result
        };
}
