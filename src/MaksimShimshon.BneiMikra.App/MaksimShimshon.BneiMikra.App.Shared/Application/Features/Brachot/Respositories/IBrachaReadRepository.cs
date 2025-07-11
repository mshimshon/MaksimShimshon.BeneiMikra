using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Respositories;
public interface IBrachaReadRepository
{
    Task<BrachaEntity?> GetById(string id);
    Task<SearchResultEntity<BrachaEntity>?> Search(string? keywords, string? sortBy, int page = 1);
}
