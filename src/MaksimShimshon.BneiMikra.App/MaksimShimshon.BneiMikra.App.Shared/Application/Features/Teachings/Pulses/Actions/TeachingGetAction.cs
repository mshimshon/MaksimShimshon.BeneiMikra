namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Actions;
public record TeachingGetAction : ISafeAction
{
    public int Page { get; init; } = 1;
}
