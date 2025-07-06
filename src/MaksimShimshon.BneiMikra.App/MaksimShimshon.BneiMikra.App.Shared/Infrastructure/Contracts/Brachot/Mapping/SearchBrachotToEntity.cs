using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot.Mapping;
internal class SearchBrachotToEntity : ICoreMapHandler<StrapiResponse<BrachaResponse>, SearchResultEntity<BrachaEntity>>
{
    private readonly ICoreMap _coreMap;

    public SearchBrachotToEntity(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }
    public SearchResultEntity<BrachaEntity> Handler(StrapiResponse<BrachaResponse> data)
        => new SearchResultEntity<BrachaEntity>()
        {
            Entities = _coreMap.MapEachTo<BrachaResponse, BrachaEntity>(data.Data),
            Page = data.Meta?.Pagination?.Page ?? 1,
            TotalPage = data.Meta?.Pagination?.PageCount ?? 1
        };
    public async Task<SearchResultEntity<BrachaEntity>> HandlerAsync(StrapiResponse<BrachaResponse> data)
        => await Task.FromResult(Handler(data));
}
