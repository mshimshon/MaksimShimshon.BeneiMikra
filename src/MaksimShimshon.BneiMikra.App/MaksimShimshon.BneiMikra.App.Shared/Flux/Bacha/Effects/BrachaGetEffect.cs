using MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Effects;
internal class BrachaGetEffect : Effect<BrachaGetAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public BrachaGetEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(BrachaGetAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint("api/blessings");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            string url = urlBuilder.ToString();

            var nextAction = new BrachaGetResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<BrachaLiteResponse>>>();
            var nextAction = new BrachaGetResultAction()
            {
                IsLoading = false,
                Result = result?.Data
            };
            dispatcher.Dispatch(nextAction);
        }, () =>
        {
            var nextAction = new BrachaGetResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });
    }
}
