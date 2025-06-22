using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Effects;
internal class TeachingGetEffect : IEffect<TeachingGetAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public TeachingGetEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }

    public async Task EffectAsync(TeachingGetAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint("api/teachings");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["populate[0]"] = "article";
            var url = urlBuilder.ToString();
            var nextAction = new TeachingGetResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<TeachingResponse>>>();
            var nextAction = new TeachingGetResultAction()
            {
                Result = result?.Data
            };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        }, async () =>
        {
            var nextAction = new TeachingGetResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }
}