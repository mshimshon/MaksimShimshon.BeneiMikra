using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Effects;
internal class BrachaGetOneEffect : IEffect<BrachaGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public BrachaGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(BrachaGetOneAction action, StatePulse.Net.IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint($"api/blessings/{action.DocumentId}");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["populate[0]"] = "TanakhReferences";
            var url = urlBuilder.ToString();

            var nextAction = new BrachaGetOneResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<BrachaResponse>>();
            var nextAction = new BrachaGetOneResultAction()
            {
                IsLoading = false,
                Result = result?.Data
            };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        }, async () =>
        {
            var nextAction = new BrachaGetOneResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }
}
