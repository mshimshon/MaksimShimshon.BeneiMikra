namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
public record CategoryResponse : BaseEntityResponse
{
    public string Slug { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
}
