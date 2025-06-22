using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Actions;
public record SnackPushNotificationAction(Severity Severity) : IAction
{
    public string? Message { get; set; }
    public RenderFragment? Fragment { get; set; }
}
