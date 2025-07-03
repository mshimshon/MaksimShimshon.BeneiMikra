using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Layout;
public partial class AppTopBar : ComponentBase
{
    private AppTopBarViewModel ViewModel { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<AppTopBarViewModel>(() => this, ShouldUpdate);

        ViewModel = vmHook.GetViewModel<AppTopBarViewModel>()!;
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);
}
