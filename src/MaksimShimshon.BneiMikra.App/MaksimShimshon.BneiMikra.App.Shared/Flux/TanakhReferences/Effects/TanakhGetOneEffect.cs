using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Contracts;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Effects;
internal class TanakhGetOneEffect : Effect<TanakhGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;
    private readonly IState<TanakhViewState> _tanakhState;

    public TanakhGetOneEffect(IDispatcherClient dispatcherClient, IState<TanakhViewState> tanakhState)
    {
        _dispatcherClient = dispatcherClient;
        _tanakhState = tanakhState;
    }
    public override async Task HandleAsync(TanakhGetOneAction action, IDispatcher dispatcher)
    {
        if (_tanakhState.Value.Chapiter != default && action.Verse != default)
        {
            var cachedVerses =
                _tanakhState.Value.Chapiter.FirstOrDefault(p => p.Book == action.Book && p.Verse == action.Verse && p.Chapiter == action.Chapiter);
            if (cachedVerses != default)
            {
                dispatcher.Dispatch(new TanakhGetOneVerseResultAction() { IsLoading = false, Result = cachedVerses });
                return;
            }

        }
        await _dispatcherClient.DispatchApi(async client =>
        {
            var urlBuilder = client.CreateEndpoint($"api/torahs");
            var query = urlBuilder.Query;
            query["locale"] = "en";
            query["filters[Book][$eq]"] = action.Book;
            query["filters[Chapiter][$eq]"] = action.Chapiter.ToString();
            if (action.Verse != default)
                query["filters[Verse][$eq]"] = action.Verse.ToString()!;

            string url = urlBuilder.ToString();

            var nextAction = new TanakhGetOneVerseResultAction() { IsLoading = true };
            dispatcher.Dispatch(nextAction);
            return await client.GetAsync(url);
        }, async response =>
        {
            if (action.Verse != default)
            {
                var result = await response.Content.ReadFromJsonAsync<StrapiResponse<TanakhVerseResponse>>();
                var nextAction = new TanakhGetOneVerseResultAction()
                {
                    IsLoading = false,
                    Result = result?.Data
                };
                dispatcher.Dispatch(nextAction);
            }
            else
            {
                var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<TanakhVerseResponse>>>();
                var nextAction = new TanakhGetOnChapiterResultAction()
                {
                    IsLoading = false,
                    Result = result?.Data
                };
                dispatcher.Dispatch(nextAction);
            }

        }, () =>
        {
            var nextAction = new TanakhGetOneVerseResultAction() { IsLoading = false };
            dispatcher.Dispatch(nextAction);
            return Task.CompletedTask;
        });
    }
}
