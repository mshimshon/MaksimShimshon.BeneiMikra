using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Queries;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Queries.Handlers;
internal class SearchBrachotHandler : IRequestHandler<SearchBrachotQuery, SearchResultEntity<BrachaEntity>>
{
    private readonly IBrachaReadRepository _brachaReadRepository;

    public SearchBrachotHandler(
        IBrachaReadRepository brachaReadRepository)
    {
        _brachaReadRepository = brachaReadRepository;
    }
    public async Task<SearchResultEntity<BrachaEntity>> Handle(SearchBrachotQuery request, CancellationToken cancellationToken)
        => await _brachaReadRepository.Search(request.Keywords, request.SortBy, request.Page);
}
