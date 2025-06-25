namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
public record BlockQuotationResponse
{
    public string? Title { get; set; }
    public string Body { get; set; } = default!;
}
