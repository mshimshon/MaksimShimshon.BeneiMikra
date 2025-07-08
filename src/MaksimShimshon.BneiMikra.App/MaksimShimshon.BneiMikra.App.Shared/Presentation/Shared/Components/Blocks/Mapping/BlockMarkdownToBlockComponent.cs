using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks.Mapping;
internal class BlockMarkdownToBlockComponent : ICoreMapHandler<BlockMarkdownResponse, BlockComponent>
{
    public BlockMarkdownToBlockComponent()
    {

    }
    public BlockComponent Handler(BlockMarkdownResponse data, ICoreMap alsoMap)
    {
        return new()
        {
            Component = nameof(BlockMarkdown),
            Paramaters = new Dictionary<string, object?>()
            {
                [nameof(BlockMarkdown.Body)] = data.Body
            }
        };
    }

}
