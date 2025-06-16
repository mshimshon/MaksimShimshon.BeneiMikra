namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record AuthorResponse : BaseEntityResponse
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
}
