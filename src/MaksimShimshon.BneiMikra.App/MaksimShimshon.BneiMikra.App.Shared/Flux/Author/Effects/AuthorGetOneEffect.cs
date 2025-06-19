using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Effects;
internal class AuthorGetOneEffect : Effect<AuthorGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public AuthorGetOneEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(AuthorGetOneAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint($"api/authors/{action.DocumentId}");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["populate[0]"] = "articles";
            query["populate[1]"] = "biography.blocks";
            string url = urlBuilder.ToString();
            var nextAction = new AuthorGetOneResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync(url);
        }, async response =>
        {
            var result = await response.Content.ReadFromJsonAsync<StrapiResponse<AuthorResponse>>();
            var nextAction = new AuthorGetOneResultAction()
            {
                IsLoading = false,
                Result = result?.Data ?? default
            };
            dispatcher.Dispatch(nextAction);
        }, () =>
        {
            var nextAction = new AuthorGetOneResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });
    }
}
