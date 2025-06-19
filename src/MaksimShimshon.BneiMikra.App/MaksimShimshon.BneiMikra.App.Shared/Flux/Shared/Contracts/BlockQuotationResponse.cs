namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record BlockQuotationResponse
{
    public string? Title { get; set; }
    public string Body { get; set; } = default!;
}
