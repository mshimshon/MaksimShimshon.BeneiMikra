using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Effects;
internal class ArticleGetOneEffect : IEffect<ArticleGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public ArticleGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(ArticleGetOneAction action, StatePulse.Net.IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var nextAction = new ArticleGetOneResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
            return await client.GetAsync($"api/articles/{action.Id}?&locale=en&populate=*");
        }, async response =>
        {
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<StrapiResponse<ArticleResponse>>(json, GlobalJsonOptions.UseGlobal());
            var nextAction = new ArticleGetOneResultAction()
            {
                IsLoading = false,
                Result = result?.Data ?? default
            };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        }, async () =>
        {
            var nextAction = new ArticleGetOneResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }

}
