using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Bracha;
public partial class BrachaLiteItem
{
    [Parameter]
    public BrachaLiteResponse Data { get; set; } = default!;
}
