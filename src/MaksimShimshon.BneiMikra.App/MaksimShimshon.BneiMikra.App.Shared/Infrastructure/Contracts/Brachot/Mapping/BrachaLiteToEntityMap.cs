using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot.Mapping;
internal class BrachaLiteToEntityMap : ICoreMapHandler<BrachaLiteResponse, BrachaEntity>
{
    public BrachaEntity MapHandler(BrachaLiteResponse data) => new()
    {
        Name = data.Name,
        Gender = GenderMapper.Mapper.ContainsKey(data.Gender) ? GenderMapper.Mapper[data.Gender] : Gender.NA
    };

    public async Task<BrachaEntity> MapHandlerAsync(BrachaLiteResponse data)
        => await Task.FromResult(MapHandler(data));
}
