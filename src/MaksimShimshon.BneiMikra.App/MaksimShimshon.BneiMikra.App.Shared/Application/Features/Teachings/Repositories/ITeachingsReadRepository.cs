using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Repositories;
public interface ITeachingsReadRepository
{
    Task<SearchResultEntity<TeachingEntity>?> Search(int page = 1);
}
