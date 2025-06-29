using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Respositories;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Effects;
internal class BrachaGetEffect : IEffect<BrachaGetAction>
{
    private readonly IBrachaReadRepository _brachaReadRepository;

    public BrachaGetEffect(IBrachaReadRepository brachaReadRepository)
    {
        _brachaReadRepository = brachaReadRepository;
    }

    public async Task EffectAsync(BrachaGetAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<BrachaGetResultAction>()
                .With(p => p.IsLoading, true)
                .UsingSynchronousMode()
                .DispatchAsync();
            var result = await _brachaReadRepository.Search(default, default, action.Page);
            await dispatcher.Prepare<BrachaGetResultAction>()
                .With(p => p.IsLoading, false)
                .With(p => p.Result, result)
                .DispatchAsync();

        }
        catch (Exception)
        {
            await dispatcher.Prepare<BrachaGetResultAction>()
                .With(p => p.IsLoading, false)
                .DispatchAsync();
        }
    }
}
