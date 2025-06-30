namespace MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
public record PushErrorMessageAction : IAction
{
    public string Message { get; init; } = default!;
}
