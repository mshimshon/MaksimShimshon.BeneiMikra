using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Queries.Handlers;
internal class GetManyArticlesHandler : IRequestHandler<GetManyArticlesQuery, SearchResultEntity<ArticleEntity>>
{
    private readonly IArticleReadRepository _articleReadRepository;

    public GetManyArticlesHandler(IArticleReadRepository articleReadRepository)
    {
        _articleReadRepository = articleReadRepository;
    }
    public async Task<SearchResultEntity<ArticleEntity>> Handle(GetManyArticlesQuery request, CancellationToken cancellationToken)
        => await _articleReadRepository.GetMany(request.Keywords,
            request.Categories,
            request.Page
            );
}
