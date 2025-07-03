using MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Effects;
internal class PushSuccessMessageEffect : IEffect<PushSuccessMessageAction>
{
    public async Task EffectAsync(PushSuccessMessageAction action, IDispatcher dispatcher)
        => await dispatcher.Prepare<SnackPushNotificationAction>()
        .With(p => p.Severity, Severity.Success)
        .With(p => p.Message, action.Message)
        .DispatchAsync();
}
