namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Contracts.Responses;
public record AuthorLiteResponse : BaseEntityResponse
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
}
