using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Queries;
public record SearchTeachingsQuery(int Page = 1) : IRequest<SearchResultEntity<TeachingEntity>?>
{
}
