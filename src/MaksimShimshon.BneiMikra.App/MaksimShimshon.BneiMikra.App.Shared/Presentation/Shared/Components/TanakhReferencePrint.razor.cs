using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class TanakhReferencePrint : ComponentBase
{
    [Parameter]
    public string BookName { get; set; } = default!;

    [Parameter]
    public int Chapiter { get; set; }

    [Parameter]
    public int Verse { get; set; }

    [Parameter]
    public string? Note { get; set; }

    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;

    private TanakhReferencePrintViewModel ViewModel { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<TanakhReferencePrintViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));

        ViewModel = vmHook.GetViewModel<TanakhReferencePrintViewModel>()!;
        await ViewModel.Initialize(BookName, Chapiter, Verse);
    }
}
