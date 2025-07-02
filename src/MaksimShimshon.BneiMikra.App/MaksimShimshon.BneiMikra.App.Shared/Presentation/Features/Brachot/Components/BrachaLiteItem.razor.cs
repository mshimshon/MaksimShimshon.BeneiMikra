using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.Components;
public partial class BrachaLiteItem
{
    [Parameter]
    public BrachaEntity Data { get; set; } = default!;
}
