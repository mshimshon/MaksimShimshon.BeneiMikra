using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Utils;
using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
internal static class BlockResponseExt
{
    public static T? ConvertTo<T>(this BlockResponse blockResponse)
         => JsonSerializer.Deserialize<T>(blockResponse.RawContent, GlobalJsonOptions.UseGlobal());
}
