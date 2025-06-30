using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class BrachaReadRepository : IBrachaReadRepository
{
    public Task<BrachaEntity> GetById(string id) => throw new NotImplementedException();
    public Task<SearchResultEntity<BrachaEntity>> Search(string? keywords, string? sortBy, int page = 1) => throw new NotImplementedException();
}
