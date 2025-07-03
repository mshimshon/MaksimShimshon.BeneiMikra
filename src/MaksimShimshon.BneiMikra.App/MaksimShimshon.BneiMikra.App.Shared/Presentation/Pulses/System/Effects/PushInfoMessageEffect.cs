using MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Effects;
internal class PushInfoMessageEffect : IEffect<PushInfoMessageAction>
{
    public async Task EffectAsync(PushInfoMessageAction action, IDispatcher dispatcher)
        => await dispatcher.Prepare<SnackPushNotificationAction>()
        .With(p => p.Severity, Severity.Info)
        .With(p => p.Message, action.Message)
        .DispatchAsync();
}
