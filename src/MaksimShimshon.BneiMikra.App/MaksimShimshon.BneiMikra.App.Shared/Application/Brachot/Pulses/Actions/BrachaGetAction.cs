namespace MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
public record BrachaGetAction : ISafeAction
{
    public int Page { get; init; } = 1;
}
