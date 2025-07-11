using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.ValueObjects;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
public record TanakhVerseEntity
{
    public string Hebrew { get; init; } = default!;
    public string? Translated { get; init; }
    public BookReference Reference { get; init; } = default!;
}
