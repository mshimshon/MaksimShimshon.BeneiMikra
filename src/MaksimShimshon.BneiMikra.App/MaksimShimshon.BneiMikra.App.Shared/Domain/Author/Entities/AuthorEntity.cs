using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;
public record AuthorEntity
{
    public string Id { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Email { get; init; }
    public string? Picture { get; init; } = default!;

    public IReadOnlyList<BlockComponent> InfoParts { get; init; } = new List<BlockComponent>();

}
