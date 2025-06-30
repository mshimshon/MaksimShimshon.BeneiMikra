namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared.Blocks;
internal record BlockResponse
{
    public string Component { get; set; } = default!;
    public string RawContent { get; set; } = default!;
}
