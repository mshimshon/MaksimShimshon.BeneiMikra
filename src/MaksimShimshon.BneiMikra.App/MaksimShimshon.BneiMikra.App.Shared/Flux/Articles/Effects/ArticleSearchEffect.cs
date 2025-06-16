using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
using System.Net.Http.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Effects;
internal class ArticleSearchEffect : Effect<ArticleSearchAction>
{
    private readonly IDispatcherClient _dispatcherClient;
    private readonly IDispatcher _dispatcher;

    public ArticleSearchEffect(IDispatcherClient dispatcherClient, IDispatcher dispatcher)
    {
        _dispatcherClient = dispatcherClient;
        _dispatcher = dispatcher;
    }
    public override async Task HandleAsync(ArticleSearchAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var nextAction = new ArticleSearchResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync($"api/articles?_q={action.Keywords}&sort={action.SortBy}&locale=en&populate=author");
        }, async response =>
        {
            var str = await response.Content.ReadAsStringAsync();
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
