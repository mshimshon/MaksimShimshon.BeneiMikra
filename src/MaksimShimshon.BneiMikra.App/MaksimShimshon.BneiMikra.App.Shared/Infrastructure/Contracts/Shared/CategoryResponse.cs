namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;
public record CategoryResponse : BaseResponse
{
    public string Slug { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
}
