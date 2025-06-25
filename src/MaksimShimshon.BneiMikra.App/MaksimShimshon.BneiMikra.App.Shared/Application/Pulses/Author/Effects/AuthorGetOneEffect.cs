using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Effects;
internal class AuthorGetOneEffect : IEffect<AuthorGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public AuthorGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(AuthorGetOneAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint($"api/authors/{action.DocumentId}");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["populate[0]"] = "articles";
            query["populate[1]"] = "biography.blocks";
            var url = urlBuilder.ToString();
            var nextAction = new AuthorGetOneResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<AuthorResponse>>();
            var nextAction = new AuthorGetOneResultAction()
            {
                IsLoading = false,
                Result = result?.Data ?? default
            };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        }, async () =>
        {
            var nextAction = new AuthorGetOneResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }
}
