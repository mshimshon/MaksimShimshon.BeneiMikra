using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class Quotation
{
    [Parameter] public string? Cite { get; set; }
    [Parameter] public string Quote { get; set; }

}
