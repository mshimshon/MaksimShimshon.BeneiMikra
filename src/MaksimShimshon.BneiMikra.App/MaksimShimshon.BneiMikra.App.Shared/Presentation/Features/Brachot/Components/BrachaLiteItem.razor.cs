using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.Components;
public partial class BrachaLiteItem
{
    [Parameter]
    public BrachaEntity Data { get; set; } = default!;

    private string Gender { get; set; } = Icons.Material.Rounded.Transgender;
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        if (Data.Gender == Domain.Shared.Enums.Gender.Male)
            Gender = Icons.Material.Rounded.Male;
        else if (Data.Gender == Domain.Shared.Enums.Gender.Female)
            Gender = Icons.Material.Rounded.Female;
    }
}
