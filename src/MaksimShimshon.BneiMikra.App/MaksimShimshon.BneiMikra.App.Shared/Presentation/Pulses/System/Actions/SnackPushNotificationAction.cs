using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;
public record SnackPushNotificationAction : IAction
{
    public Severity Severity { get; set; }
    public string? Message { get; set; }
    public RenderFragment? Fragment { get; set; }
}
