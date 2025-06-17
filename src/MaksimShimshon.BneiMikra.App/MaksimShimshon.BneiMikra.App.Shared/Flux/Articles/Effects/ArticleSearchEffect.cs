
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
using System.Net.Http.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Effects;
internal class ArticleSearchEffect : Effect<ArticleSearchAction>
{
    private readonly IDispatcherClient _dispatcherClient;
    public ArticleSearchEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(ArticleSearchAction action, IDispatcher dispatcher)
    {
        // filters[category][name][$eq]=Essays
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint("api/articles");
            var query = urlBuilder.Query;
            if (!string.IsNullOrWhiteSpace(action.Category))
                query["filters[category][slug][$eq]"] = action.Category;
            else // Search within only article with assigned categories
                query["filters[category][id][$notNull]"] = "true";
            if (!string.IsNullOrWhiteSpace(action.Keywords))
                query["_q"] = action.Keywords;
            query["locale"] = "en";
            query["populate[0]"] = "author";
            query["populate[1]"] = "category";
            string url = urlBuilder.ToString();
            var nextAction = new ArticleSearchResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<ArticleLiteResponse>>>();
            var nextAction = new ArticleSearchResultAction()
            {
                Result = new SearchResultResponse<ArticleLiteResponse>()
                {
                    Result = result?.Data ?? new(),
                    Pagination = result?.Meta?.Pagination ?? new()
                }
            };
            dispatcher.Dispatch(nextAction);
        }, () =>
        {
            var nextAction = new ArticleSearchResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });
    }
}
