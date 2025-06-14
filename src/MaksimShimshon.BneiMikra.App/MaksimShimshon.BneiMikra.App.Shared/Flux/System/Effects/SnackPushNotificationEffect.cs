using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.System.Effects;
internal class SnackPushNotificationEffect : Effect<SnackPushNotificationAction>
{
    public SnackPushNotificationEffect(ISnackbar snackbar)
    {
        Snackbar = snackbar;
    }

    public ISnackbar Snackbar { get; }

    public override Task HandleAsync(SnackPushNotificationAction action, IDispatcher dispatcher)
    {
        if (action.Fragment == default || action.Message == default) return Task.CompletedTask;
        if (action.Message != default) Snackbar.Add((MarkupString)action.Message, action.Severity);
        else Snackbar.Add(action.Fragment, action.Severity);
        return Task.CompletedTask;
    }
}
