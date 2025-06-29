using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Queries.Handlers;
internal class GetBrachaByIdHandler : IRequestHandler<GetBrachaByIdQuery, BrachaEntity>
{
    private readonly IBrachaReadRepository _brachaReadRepository;

    public GetBrachaByIdHandler(IBrachaReadRepository brachaReadRepository)
    {
        _brachaReadRepository = brachaReadRepository;
    }
    public async Task<BrachaEntity> Handle(GetBrachaByIdQuery request, CancellationToken cancellationToken)
        => await _brachaReadRepository.GetById(request.Id);
}
