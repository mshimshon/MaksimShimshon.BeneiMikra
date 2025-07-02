using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Queries;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Pulses.Effects;
internal class AuthorGetOneEffect : IEffect<AuthorGetOneAction>
{
    private readonly IMediator _mediator;

    public AuthorGetOneEffect(
        IMediator mediator
        )
    {
        _mediator = mediator;
    }
    public async Task EffectAsync(AuthorGetOneAction action, IDispatcher dispatcher)
    {
        await dispatcher.Prepare<AuthorGetOneResultAction>()
            .With(p => p.IsLoading, true)
            .UsingSynchronousMode()
            .DispatchAsync();
        try
        {
            var result = await _mediator.Send(new GetAuthorByIdQuery(action.DocumentId));
            await dispatcher.Prepare<AuthorGetOneResultAction>()
                .With(p => p.IsLoading, false)
                .With(p => p.Result, result)
                .DispatchAsync();
        }
        catch (Exception)
        {
            await dispatcher.Prepare<AuthorGetOneResultAction>()
                .With(p => p.IsLoading, false)
                .DispatchAsync();
        }
    }
}
