namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
public record BlockResponse
{
    public string Component { get; set; } = default!;
    public string RawContent { get; set; } = default!;
}
