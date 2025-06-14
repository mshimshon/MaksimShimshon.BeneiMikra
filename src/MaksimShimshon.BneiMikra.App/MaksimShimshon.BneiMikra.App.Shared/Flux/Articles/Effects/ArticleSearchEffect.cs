using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Effects;
internal class ArticleSearchEffect : Effect<ArticleSearchAction>
{
    private readonly IDispatcherClient _dispatcherClient;

    public ArticleSearchEffect(IDispatcherClient dispatcherClient)
    {
        _dispatcherClient = dispatcherClient;
    }
    public override async Task HandleAsync(ArticleSearchAction action, IDispatcher dispatcher)
    {
        await _dispatcherClient.DispatchApi(async client =>
        {
            return await client.GetAsync($"api/articles?_q={action.Keywords}&sort={action.SortBy}&locale=en&populate=author");
        }, response =>
        {
            return Task.CompletedTask;
        }, () =>
        {
            return Task.CompletedTask;
        });
    }
}
