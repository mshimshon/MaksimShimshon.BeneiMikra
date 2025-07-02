using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks.Mapping;
internal class QuotationToBlockComponent : ICoreMapHandler<BlockQuotationResponse, BlockComponent>
{
    public BlockComponent MapHandler(BlockQuotationResponse data) => new()
    {
        Component = "QuotationComponent",
        Paramaters = new Dictionary<string, object?>()
        {
            ["Title"] = data.Title ?? null,
            ["Body"] = data.Body
        }
    };
    public async Task<BlockComponent> MapHandlerAsync(BlockQuotationResponse data)
        => await Task.FromResult(MapHandler(data));
}
