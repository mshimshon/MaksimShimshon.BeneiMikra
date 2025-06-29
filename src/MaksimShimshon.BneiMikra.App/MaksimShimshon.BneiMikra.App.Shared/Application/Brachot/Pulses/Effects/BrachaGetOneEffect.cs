using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Queries;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Effects;
internal class BrachaGetOneEffect : IEffect<BrachaGetOneAction>
{
    private readonly IMediator _mediator;

    public BrachaGetOneEffect(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task EffectAsync(BrachaGetOneAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<BrachaGetOneResultAction>()
                .With(p => p.IsLoading, true)
                .UsingSynchronousMode()
                .DispatchAsync();
            var result = await _mediator.Send(new GetBrachaByIdQuery(action.DocumentId));
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
