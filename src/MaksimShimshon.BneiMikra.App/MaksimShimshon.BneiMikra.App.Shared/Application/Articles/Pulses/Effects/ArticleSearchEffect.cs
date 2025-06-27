using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Repositories;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Effects;
internal class ArticleSearchEffect : IEffect<ArticleSearchAction>
{
    private readonly IArticleReadRepository _articleReadRepository;

    public ArticleSearchEffect(IArticleReadRepository articleReadRepository)
    {
        _articleReadRepository = articleReadRepository;
    }

    public async Task EffectAsync(ArticleSearchAction action, IDispatcher dispatcher)
    {
        await dispatcher.Prepare<ArticleSearchResultAction>()
            .With(p => p.IsLoading, true)
            .UsingSynchronousMode()
            .DispatchAsync();
        try
        {
            var result = await _articleReadRepository
                .GetMany(action.Keywords,
                action.Category,
                action.SortBy,
                action.Page);

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
