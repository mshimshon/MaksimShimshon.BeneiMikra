using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Teachings.Mapping;
internal class SearchTeachingsToEntityMap : ICoreMapHandler<StrapiResponse<TeachingResponse>, SearchResultEntity<TeachingEntity>>
{
    public SearchResultEntity<TeachingEntity> Handler(StrapiResponse<TeachingResponse> data, ICoreMap alsoMap)
        => new SearchResultEntity<TeachingEntity>()
        {
            Entities = alsoMap.MapEachTo<TeachingResponse, TeachingEntity>(data.Data),
            Page = data.Meta?.Pagination?.Page ?? 1,
            TotalPage = data.Meta?.Pagination?.PageCount ?? 1
        };
}
