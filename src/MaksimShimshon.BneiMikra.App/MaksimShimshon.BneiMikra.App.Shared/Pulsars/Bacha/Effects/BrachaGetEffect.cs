using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Effects;
internal class BrachaGetEffect : IEffect<BrachaGetAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public BrachaGetEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(BrachaGetAction action, StatePulse.Net.IDispatcher dispatcher)
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
