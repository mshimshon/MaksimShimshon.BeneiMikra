namespace MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
public record PushNeutralMessageAction : IAction
{
    public string Message { get; init; } = default!;
}
