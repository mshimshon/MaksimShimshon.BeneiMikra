using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class Divider : MudDivider
{
    [Parameter] public string? VerticalSpacing { get; set; }
    [Parameter] public string? HorizontalSpacing { get; set; }
    [Parameter] public bool Invisible { get; set; }


    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        var style = StyleStringBuilder.CreateStyle();
        if (!string.IsNullOrWhiteSpace(VerticalSpacing))
            style.Add("margin-top", VerticalSpacing)
                 .Add("margin-bottom", VerticalSpacing);
        if (!string.IsNullOrWhiteSpace(HorizontalSpacing))
            style.Add("margin-right", HorizontalSpacing)
                 .Add("margin-left", HorizontalSpacing);
        if (Invisible) style.Add("visibility", "hidden");

        Style += style.ToString();
    }
}
