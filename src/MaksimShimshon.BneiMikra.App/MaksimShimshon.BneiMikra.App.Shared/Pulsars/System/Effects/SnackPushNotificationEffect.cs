using MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Actions;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Effects;
internal class SnackPushNotificationEffect : IEffect<SnackPushNotificationAction>
{
    public SnackPushNotificationEffect(ISnackbar snackbar)
    {
        Snackbar = snackbar;
    }

    public ISnackbar Snackbar { get; }

    public Task EffectAsync(SnackPushNotificationAction action, IDispatcher dispatcher)
    {
        if (action.Fragment == default && action.Message == default) return Task.CompletedTask;
        if (action.Message != default) Snackbar.Add((MarkupString)action.Message, action.Severity);
        else if (action.Fragment != default) Snackbar.Add(action.Fragment, action.Severity);
        return Task.CompletedTask;
    }
}
