using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Bracha;
public partial class BrachaLiteItem
{
    [Parameter]
    public BrachaLiteResponse Data { get; set; } = default!;
}
