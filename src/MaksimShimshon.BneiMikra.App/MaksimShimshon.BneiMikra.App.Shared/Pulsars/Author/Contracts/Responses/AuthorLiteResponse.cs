using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Contracts.Responses;
public record AuthorLiteResponse : BaseEntityResponse
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
}
