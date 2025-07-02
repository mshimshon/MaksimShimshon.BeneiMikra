using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class TanakhReferenceDialog : ComponentBase
{
    [Parameter]
    public TanakhBook BookName { get; set; } = default!;

    [Parameter]
    public int Chapiter { get; set; }

    [Parameter]
    public int Verse { get; set; }

    [Parameter]
    public string? Note { get; set; }

}
