using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Repositories;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Effects;
internal class ArticleGetOneEffect : IEffect<ArticleGetOneAction>
{
    private readonly IArticleReadRepository _articleReadRepository;

    public ArticleGetOneEffect(IArticleReadRepository articleReadRepository)
    {
        _articleReadRepository = articleReadRepository;
    }

    public async Task EffectAsync(ArticleGetOneAction action, IDispatcher dispatcher)
    {
        await dispatcher.Prepare<ArticleGetOneResultAction>()
            .With(p => p.IsLoading, true)
            .UsingSynchronousMode()
            .DispatchAsync();
        try
        {
            var result = await _articleReadRepository.GetById(action.Id);
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
