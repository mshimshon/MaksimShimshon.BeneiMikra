using MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Effects;
internal class BrachaGetOneEffect : Effect<BrachaGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public BrachaGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(BrachaGetOneAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint($"api/blessings/{action.DocumentId}");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["populate[0]"] = "TanakhReferences";
            string url = urlBuilder.ToString();

            var nextAction = new BrachaGetOneResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<BrachaResponse>>();
            var nextAction = new BrachaGetOneResultAction()
            {
                Result = result?.Data
            };
            dispatcher.Dispatch(nextAction);
        }, () =>
        {
            var nextAction = new BrachaGetOneResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });
    }
}
