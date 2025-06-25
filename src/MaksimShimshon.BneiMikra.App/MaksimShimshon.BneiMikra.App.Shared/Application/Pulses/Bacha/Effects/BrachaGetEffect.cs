using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Effects;
internal class BrachaGetEffect : IEffect<BrachaGetAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public BrachaGetEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(BrachaGetAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint("api/blessings");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            var url = urlBuilder.ToString();

            var nextAction = new BrachaGetResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<BrachaLiteResponse>>>();
            var nextAction = new BrachaGetResultAction()
            {
                IsLoading = false,
                Result = result?.Data
            };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        }, async () =>
        {
            var nextAction = new BrachaGetResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }
}
