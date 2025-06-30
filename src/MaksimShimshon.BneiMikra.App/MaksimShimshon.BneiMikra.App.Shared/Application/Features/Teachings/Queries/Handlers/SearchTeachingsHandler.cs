using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Queries.Handlers;
internal class SearchTeachingsHandler : IRequestHandler<SearchTeachingsQuery, SearchResultEntity<ArticleEntity>?>
{
    private readonly ITeachingsReadRepository _teachingsReadRepository;

    public SearchTeachingsHandler(ITeachingsReadRepository teachingsReadRepository)
    {
        _teachingsReadRepository = teachingsReadRepository;
    }
    public async Task<SearchResultEntity<ArticleEntity>?> Handle(SearchTeachingsQuery request, CancellationToken cancellationToken)
        => await _teachingsReadRepository.Search(request.Page);
}
