using MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Effects;
internal class PushNeutralMessageEffect : IEffect<PushNeutralMessageAction>
{
    public async Task EffectAsync(PushNeutralMessageAction action, IDispatcher dispatcher)
        => await dispatcher.Prepare<SnackPushNotificationAction>()
        .With(p => p.Severity, Severity.Normal)
        .With(p => p.Message, action.Message)
        .DispatchAsync();
}