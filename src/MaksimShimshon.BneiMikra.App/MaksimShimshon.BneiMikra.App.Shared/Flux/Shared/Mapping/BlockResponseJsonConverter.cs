using System.Text.Json;
using System.Text.Json.Serialization;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Mapping;
internal class BlockResponseJsonConverter : JsonConverter<BlockResponse>
{
    public override BlockResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        var component = root.GetProperty("__component").GetString();
        var rawJson = root.GetRawText();

        return new BlockResponse
        {
            Component = component!,
            RawContent = rawJson
        };
    }

    public override void Write(Utf8JsonWriter writer, BlockResponse value, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.Parse(value.RawContent);
        doc.RootElement.WriteTo(writer);
    }
}
