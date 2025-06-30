using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;
internal static class BlockMapper
{
    public static Dictionary<string, Type> Matches { get; } = new()
    {
        ["shared.rich-text"] = typeof(BlockMarkdownResponse),
        ["shared.quote"] = typeof(BlockQuotationResponse),
        ["shared.tanakh-reference"] = typeof(TanakhReferenceResponse),
    };
}
