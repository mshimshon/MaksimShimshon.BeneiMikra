using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
public record SnackPushNotificationAction(Severity Severity)
{
    public string? Message { get; set; }
    public RenderFragment? Fragment { get; set; }
}
