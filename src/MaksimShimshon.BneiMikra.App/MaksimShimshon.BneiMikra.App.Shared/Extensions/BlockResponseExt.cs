using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Extensions;
internal static class BlockResponseExt
{
    public static T? ConvertTo<T>(this BlockResponse blockResponse)
         => JsonSerializer.Deserialize<T>(blockResponse.RawContent, GlobalJsonOptions.UserGlobal());
}
