using System.Text.Json.Serialization;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
public record ArticleBlockResponse
{
    [JsonPropertyName("__component")]
    public string Component { get; set; } = default!;

    public int Id { get; set; }
    public string Body { get; set; } = default!;
}
