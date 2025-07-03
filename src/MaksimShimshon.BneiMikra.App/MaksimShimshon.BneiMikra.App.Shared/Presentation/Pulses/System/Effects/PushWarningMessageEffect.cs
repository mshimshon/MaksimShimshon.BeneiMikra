using MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Effects;
internal class PushWarningMessageEffect : IEffect<PushWarningMessageAction>
{
    public async Task EffectAsync(PushWarningMessageAction action, IDispatcher dispatcher)
        => await dispatcher.Prepare<SnackPushNotificationAction>()
        .With(p => p.Severity, Severity.Warning)
        .With(p => p.Message, action.Message)
        .DispatchAsync();
}
