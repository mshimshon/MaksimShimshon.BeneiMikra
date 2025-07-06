using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;
using Strapi.Net.Utilities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;
internal static class BlockMapper
{
    public static Dictionary<string, Func<ICoreMap, string, BlockComponent>> Matches { get; } = new()
    {
        ["shared.rich-text"] = (map, json)
            => map.MapTo<BlockMarkdownResponse, BlockComponent>(StrapiDecoder.DecodePart<BlockMarkdownResponse>(json)!),
        ["shared.quote"] = (map, json)
            => map.MapTo<BlockQuotationResponse, BlockComponent>(StrapiDecoder.DecodePart<BlockQuotationResponse>(json)!),
        ["shared.tanakh-reference"] = (map, json)
            => map.MapTo<TanakhReferenceResponse, BlockComponent>(StrapiDecoder.DecodePart<TanakhReferenceResponse>(json)!),
    };
}
