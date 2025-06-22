using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class Loader
{
    [Parameter] public RenderFragment ChildContent { get; set; } = default!;
}
