using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
public record BrachaEntity
{
    public string Name { get; init; } = default!;
    public Gender Gender { get; init; } = Gender.NA;
    public BrachaDetailsEntity? Details { get; init; }
}
