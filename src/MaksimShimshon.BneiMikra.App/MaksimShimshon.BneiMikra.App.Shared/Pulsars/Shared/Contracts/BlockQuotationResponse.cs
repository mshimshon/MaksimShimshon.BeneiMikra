namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
public record BlockQuotationResponse
{
    public string? Title { get; set; }
    public string Body { get; set; } = default!;
}
