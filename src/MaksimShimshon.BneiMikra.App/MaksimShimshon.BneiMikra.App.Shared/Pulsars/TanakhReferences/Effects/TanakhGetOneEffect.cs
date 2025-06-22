using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Contracts;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.TanakhReferences.Effects;
internal class TanakhGetOneEffect : IEffect<TanakhGetOneAction>
{
    private readonly IDispatcherClient _dispatcherClient;
    private readonly IStateAccessor<TanakhViewState> _tanakhState;

    public TanakhGetOneEffect(IDispatcherClient dispatcherClient, IStateAccessor<TanakhViewState> tanakhState)
    {
        _dispatcherClient = dispatcherClient;
        _tanakhState = tanakhState;
    }

    public async Task EffectAsync(TanakhGetOneAction action, IDispatcher dispatcher)
    {
        if (_tanakhState.State.Chapiter != default && action.Verse != default)
        {
            var cachedVerses =
                _tanakhState.State.Chapiter.FirstOrDefault(p => p.Book == action.Book && p.Verse == action.Verse && p.Chapiter == action.Chapiter);
            if (cachedVerses != default)
            {
                await dispatcher.Prepare<TanakhGetOneVerseResultAction>()
                    .With(p => p.IsLoading, false)
                    .With(p => p.Result, cachedVerses).DispatchAsync();
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

            var url = urlBuilder.ToString();

            var nextAction = new TanakhGetOneVerseResultAction() { IsLoading = true };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
            return await client.GetAsync(url);
        }, async response =>
        {
            if (action.Verse != default)
            {
                var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<TanakhVerseResponse>>>();
                var nextAction = new TanakhGetOneVerseResultAction()
                {
                    IsLoading = false,
                    Result = result?.Data?.FirstOrDefault()
                };
                await dispatcher.Prepare(() => nextAction).DispatchAsync();
            }
            else
            {
                var result = await response.Content.ReadFromJsonAsync<StrapiResponse<List<TanakhVerseResponse>>>();
                var nextAction = new TanakhGetOnChapiterResultAction()
                {
                    IsLoading = false,
                    Result = result?.Data
                };
                await dispatcher.Prepare(() => nextAction).DispatchAsync();
            }

        }, async () =>
        {
            var nextAction = new TanakhGetOneVerseResultAction() { IsLoading = false };
            await dispatcher.Prepare(() => nextAction).DispatchAsync();
        });
    }
}
