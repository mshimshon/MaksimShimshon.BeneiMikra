using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Effects;
internal class TeachingGetEffect : IEffect<TeachingGetAction>
{
    private readonly IMediator _mediator;

    public TeachingGetEffect(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task EffectAsync(TeachingGetAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<TeachingGetResultAction>()
                .With(p => p.IsLoading, true)
                .UsingSynchronousMode()
                .DispatchAsync();

            var result = await _mediator.Send(new SearchTeachingsQuery(action.Page));

            await dispatcher.Prepare<TeachingGetResultAction>()
                .With(p => p.IsLoading, true)
                .With(p => p.Result, result)
                .DispatchAsync();
        }
        catch (Exception)
        {
            await dispatcher.Prepare<TeachingGetResultAction>()
                .With(p => p.IsLoading, false)
                .DispatchAsync();
        }
    }
}