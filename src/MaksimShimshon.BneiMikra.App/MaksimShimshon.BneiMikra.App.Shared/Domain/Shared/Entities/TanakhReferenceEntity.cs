using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.ValueObjects;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
public record TanakhReferenceEntity
{
    public BookReference Reference { get; init; } = default!;
    public string? Note { get; init; }
}
