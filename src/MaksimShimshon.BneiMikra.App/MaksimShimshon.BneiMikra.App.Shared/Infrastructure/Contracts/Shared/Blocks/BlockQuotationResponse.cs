namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks;
internal record BlockQuotationResponse
{
    public string? Title { get; set; }
    public string Body { get; set; } = default!;
}
