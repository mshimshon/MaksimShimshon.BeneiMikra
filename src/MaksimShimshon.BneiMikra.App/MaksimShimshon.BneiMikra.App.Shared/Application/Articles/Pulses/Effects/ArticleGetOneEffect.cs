using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Utils;
using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Effects;
internal class ArticleGetOneEffect : IEffect<ArticleGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public ArticleGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(ArticleGetOneAction action, IDispatcher dispatcher)
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
