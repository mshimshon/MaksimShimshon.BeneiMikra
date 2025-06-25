using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
public record BrachaEntity
{
    public string Hebrew { get; init; } = default!;
    public string? Translated { get; init; }
    public List<TanakhReferenceEntity> TanakhReferences { get; init; } = new();
}
