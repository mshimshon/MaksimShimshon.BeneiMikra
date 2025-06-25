using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Effects;
internal class ArticleSearchEffect : IEffect<ArticleSearchAction>
{
    private readonly IDispatcherClient _dispatcherClient;
    public ArticleSearchEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(ArticleSearchAction action, IDispatcher dispatcher)
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
            var url = urlBuilder.ToString();
            var nextAction = new ArticleSearchResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
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
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        }, async () =>
        {
            var nextAction = new ArticleSearchResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }
}
