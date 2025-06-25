using System.Text.Json;
using System.Text.Json.Serialization;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Utils;
public static class GlobalJsonOptions
{
    private static JsonSerializerOptions _globalOptions = new();

    public static void RegisterCustomConverters(Action<IList<JsonConverter>> register)
    {
        register(_globalOptions.Converters);
    }
    public static void SetupGlobalBehavior(Action<JsonSerializerOptions> o) => o(_globalOptions);

    public static JsonSerializerOptions UseGlobal() => _globalOptions;
}
