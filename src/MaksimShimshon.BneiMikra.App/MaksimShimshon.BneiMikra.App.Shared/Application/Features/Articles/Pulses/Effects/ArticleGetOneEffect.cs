using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Effects;
internal class ArticleGetOneEffect : IEffect<ArticleGetOneAction>
{
    private readonly IMediator _mediator;

    public ArticleGetOneEffect(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task EffectAsync(ArticleGetOneAction action, IDispatcher dispatcher)
    {
        await dispatcher.Prepare<ArticleGetOneResultAction>()
            .With(p => p.IsLoading, true)
            .Await()
            .DispatchAsync();
        try
        {
            var result = await _mediator.Send(new GetArticleQuery(action.Id));

            await dispatcher.Prepare<ArticleGetOneResultAction>()
                .With(p => p.IsLoading, false)
                .With(p => p.Result, result)
                .DispatchAsync();
        }
        catch (Exception)
        {
            await dispatcher.Prepare<ArticleGetOneResultAction>()
                .With(p => p.IsLoading, false)
                .DispatchAsync();
        }
    }
}
