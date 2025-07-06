using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Queries;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Effects;
internal class BrachaGetEffect : IEffect<BrachaGetAction>
{
    private readonly IMediator _mediator;

    public BrachaGetEffect(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task EffectAsync(BrachaGetAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<BrachaGetResultAction>()
                .With(p => p.IsLoading, true)
                .Sync()
                .DispatchAsync();
            var result = await _mediator.Send(new SearchBrachotQuery(default, default, action.Page));
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
