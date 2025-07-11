using MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Effects;
internal class PushErrorMessageEffect : IEffect<PushErrorMessageAction>
{
    public async Task EffectAsync(PushErrorMessageAction action, IDispatcher dispatcher)
        => await dispatcher.Prepare<SnackPushNotificationAction>()
        .With(p => p.Severity, Severity.Error)
        .With(p => p.Message, action.Message)
        .DispatchAsync();
}
