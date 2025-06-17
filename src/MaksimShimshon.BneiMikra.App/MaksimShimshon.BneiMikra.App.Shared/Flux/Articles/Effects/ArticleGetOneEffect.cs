using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
using System.Net.Http.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Effects;
internal class ArticleGetOneEffect : Effect<ArticleGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public ArticleGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(ArticleGetOneAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var nextAction = new ArticleGetOneResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync($"api/articles/{action.Id}?&locale=en&populate=*");
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<ArticleResponse>>();
            var nextAction = new ArticleGetOneResultAction()
            {
                IsLoading = false,
                Result = result?.Data ?? default
            };
            dispatcher.Dispatch(nextAction);
        }, () =>
        {
            var nextAction = new ArticleGetOneResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });

    }
}
