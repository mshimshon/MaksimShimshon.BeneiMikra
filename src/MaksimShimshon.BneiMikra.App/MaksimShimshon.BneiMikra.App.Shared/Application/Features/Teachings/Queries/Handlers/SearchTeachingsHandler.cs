using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Queries.Handlers;
internal class SearchTeachingsHandler : IRequestHandler<SearchTeachingsQuery, SearchResultEntity<TeachingEntity>?>
{
    private readonly ITeachingsReadRepository _teachingsReadRepository;

    public SearchTeachingsHandler(ITeachingsReadRepository teachingsReadRepository)
    {
        _teachingsReadRepository = teachingsReadRepository;
    }
    public async Task<SearchResultEntity<TeachingEntity>?> Handle(SearchTeachingsQuery request, CancellationToken cancellationToken)
        => await _teachingsReadRepository.Search(request.Page);
}
