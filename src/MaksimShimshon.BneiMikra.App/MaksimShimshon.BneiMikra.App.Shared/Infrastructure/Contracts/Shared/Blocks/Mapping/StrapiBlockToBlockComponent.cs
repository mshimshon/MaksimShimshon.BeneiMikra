using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks.Mapping;
internal class StrapiBlockToBlockComponent : ICoreMapHandler<BlockMarkdownResponse, BlockComponent>
{
    public StrapiBlockToBlockComponent()
    {

    }
    public BlockComponent MapHandler(BlockMarkdownResponse data)
    {
        return new()
        {
            Component = "Markdown",
            Paramaters = new Dictionary<string, object>()
            {
                ["Body"] = data.Body
            }
        };
    }

    public async Task<BlockComponent> MapHandlerAsync(BlockMarkdownResponse data)
        => await Task.FromResult(MapHandler(data));
}
