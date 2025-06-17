using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Contracts.Responses;
using System.Net.Http.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Effects;
internal class TeachingGetEffect : Effect<TeachingGetAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public TeachingGetEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(TeachingGetAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint("api/articles");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["populate[0]"] = "article";
            string url = urlBuilder.ToString();
            var nextAction = new TeachingGetResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<TeachingResponse>>>();
            var nextAction = new TeachingGetResultAction()
            {
                Result = result?.Data
            };
            dispatcher.Dispatch(nextAction);
        }, () =>
        {
            var nextAction = new TeachingGetResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });
    }
}