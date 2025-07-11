namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Actions;
public record BrachaGetAction : ISafeAction
{
    public int Page { get; init; } = 1;
}
