using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks.Mapping;
internal class BlockMarkdownToBlockComponent : ICoreMapHandler<BlockMarkdownResponse, BlockComponent>
{
    public BlockMarkdownToBlockComponent()
    {

    }
    public BlockComponent MapHandler(BlockMarkdownResponse data)
    {
        return new()
        {
            Component = "MarkdownComponent",
            Paramaters = new Dictionary<string, object?>()
            {
                ["Body"] = data.Body
            }
        };
    }

    public async Task<BlockComponent> MapHandlerAsync(BlockMarkdownResponse data)
        => await Task.FromResult(MapHandler(data));
}
