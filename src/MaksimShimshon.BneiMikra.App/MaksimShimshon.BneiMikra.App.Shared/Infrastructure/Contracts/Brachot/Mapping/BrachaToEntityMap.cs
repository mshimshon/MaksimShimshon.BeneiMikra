using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot.Mapping;
internal class BrachaToEntityMap : ICoreMapHandler<BrachaResponse, BrachaEntity>
{
    private readonly ICoreMap _coreMap;

    public BrachaToEntityMap(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }
    public BrachaEntity MapHandler(BrachaResponse data) => new()
    {
        Id = data.DocumentId,
        Name = data.Name,
        Gender = GenderMapper.Mapper.ContainsKey(data.Gender) ? GenderMapper.Mapper[data.Gender] : Gender.NA,
        Details = new()
        {
            Hebrew = data.Hebrew,
            Translated = data.Translated,
            TanakhReferences = _coreMap.MapEachTo<TanakhReferenceResponse, TanakhReferenceEntity>(data.TanakhReferences ?? new List<TanakhReferenceResponse>()).ToList(),
        }
    };

    public async Task<BrachaEntity> MapHandlerAsync(BrachaResponse data)
        => await Task.FromResult(MapHandler(data));
}
