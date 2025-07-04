using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Teachings.Mapping;
internal class SearchTeachingsToEntityMap : ICoreMapHandler<StrapiResponse<TeachingResponse>, SearchResultEntity<TeachingEntity>>
{
    private readonly ICoreMap _coreMap;

    public SearchTeachingsToEntityMap(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }
    public SearchResultEntity<TeachingEntity> MapHandler(StrapiResponse<TeachingResponse> data)
        => new SearchResultEntity<TeachingEntity>()
        {
            Entities = _coreMap.MapEachTo<TeachingResponse, TeachingEntity>(data.Data),
            Page = data.Meta?.Pagination?.Page ?? 1,
            TotalPage = data.Meta?.Pagination?.PageCount ?? 1
        };
    public async Task<SearchResultEntity<TeachingEntity>> MapHandlerAsync(StrapiResponse<TeachingResponse> data)
        => await Task.FromResult(MapHandler(data));
}
