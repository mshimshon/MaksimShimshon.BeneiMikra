using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Bracha;
public partial class BrachaLiteItem
{
    [Parameter]
    public BrachaEntity Data { get; set; } = default!;
}
