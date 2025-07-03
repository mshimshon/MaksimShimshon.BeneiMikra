using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Layout;
public partial class MainMenu : ComponentBase
{
    [Inject] private IResourceProvider<ApplicationResource> ApplicationResourceProvider { get; set; } = default!;
    [Inject] private NavigationManager Navigator { get; set; } = default!;
    private MudDrawer Menu { get; set; } = default!;
    private MainMenuViewModel ViewModel { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<MainMenuViewModel>(() => this, ShouldUpdate);

        ViewModel = vmHook.GetViewModel<MainMenuViewModel>()!;
        return base.OnInitializedAsync();
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);
    private async Task AutoClose(string href)
    {
        await ViewModel.CloseMenu();
        Navigator.NavigateTo(href);
    }
}