using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Respositories;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Effects;
internal class BrachaGetOneEffect : IEffect<BrachaGetOneAction>
{
    private readonly IBrachaReadRepository _brachaReadRepository;

    public BrachaGetOneEffect(IBrachaReadRepository brachaReadRepository)
    {
        _brachaReadRepository = brachaReadRepository;
    }

    public async Task EffectAsync(BrachaGetOneAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<BrachaGetOneResultAction>()
                .With(p => p.IsLoading, true)
                .UsingSynchronousMode()
                .DispatchAsync();
            var result = await _brachaReadRepository.GetById(action.DocumentId);
            await dispatcher.Prepare<BrachaGetOneResultAction>()
                 .With(p => p.IsLoading, false)
                 .With(p => p.Result, result)
                 .DispatchAsync();
        }
        catch (Exception)
        {
            await dispatcher.Prepare<BrachaGetOneResultAction>()
                .With(p => p.IsLoading, false)
                .DispatchAsync();
        }
    }
}
