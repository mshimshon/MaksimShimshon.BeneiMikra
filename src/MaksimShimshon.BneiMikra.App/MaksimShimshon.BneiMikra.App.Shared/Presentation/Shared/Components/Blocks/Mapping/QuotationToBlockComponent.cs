using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks.Mapping;
internal class QuotationToBlockComponent : ICoreMapHandler<BlockQuotationResponse, BlockComponent>
{
    public BlockComponent Handler(BlockQuotationResponse data, ICoreMap alsoMap) => new()
    {
        Component = nameof(BlockQuotation),
        Paramaters = new Dictionary<string, object?>()
        {
            [nameof(BlockQuotation.Cite)] = data.Title ?? null,
            [nameof(BlockQuotation.Quote)] = data.Body
        }
    };
}
