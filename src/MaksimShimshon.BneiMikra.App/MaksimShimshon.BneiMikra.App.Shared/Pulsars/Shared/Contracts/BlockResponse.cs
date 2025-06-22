namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
public record BlockResponse
{
    public string Component { get; set; } = default!;
    public string RawContent { get; set; } = default!;
}
