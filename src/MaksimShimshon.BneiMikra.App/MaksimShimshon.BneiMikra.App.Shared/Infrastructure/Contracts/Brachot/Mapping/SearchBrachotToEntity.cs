using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot.Mapping;
internal class SearchBrachotToEntity : ICoreMapHandler<StrapiResponse<BrachaResponse>, SearchResultEntity<BrachaEntity>>
{
    public SearchResultEntity<BrachaEntity> Handler(StrapiResponse<BrachaResponse> data, ICoreMap alsoMap)
        => new SearchResultEntity<BrachaEntity>()
        {
            Entities = alsoMap.MapEachTo<BrachaResponse, BrachaEntity>(data.Data),
            Page = data.Meta?.Pagination?.Page ?? 1,
            TotalPage = data.Meta?.Pagination?.PageCount ?? 1
        };
}
