using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks;
public partial class BlockQuotation
{
    [Parameter] public string? Cite { get; set; }
    [Parameter] public string Quote { get; set; } = default!;

}
