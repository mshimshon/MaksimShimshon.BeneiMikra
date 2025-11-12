using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Effects;
internal class ArticleSearchEffect : IEffect<ArticleSearchAction>
{
    private readonly IMediator _mediator;

    public ArticleSearchEffect(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task EffectAsync(ArticleSearchAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<ArticleSearchResultAction>()
                .With(p => p.IsLoading, true)
                .Await()
                .DispatchAsync();

            var result = await _mediator.Send(new GetManyArticlesQuery()
            {
                Categories = action.Category,
                //Keywords = action.Category,
                Page = action.Page
            });

            await dispatcher.Prepare<ArticleSearchResultAction>()
                .With(p => p.IsLoading, false)
                .With(p => p.Result, result)
                .DispatchAsync();
        }
        catch (Exception)
        {
            await dispatcher.Prepare<ArticleSearchResultAction>()
                .With(p => p.IsLoading, false)
                .DispatchAsync();
        }
    }
}
