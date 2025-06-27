using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class Loader
{
    [Parameter] public RenderFragment ChildContent { get; set; } = default!;
}
