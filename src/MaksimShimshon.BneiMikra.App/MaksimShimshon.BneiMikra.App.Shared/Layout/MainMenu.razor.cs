using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Layout;
public partial class MainMenu : ComponentBase
{
    [Inject] private IState<MainMenuState> MainMenuStore { get; set; } = default!;
    [Inject] private IState<TeachingState> TeachingStore { get; set; } = default!;
    [Inject] private IResourceProvider<ApplicationResource> ApplicationResourceProvider { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    [Inject] private NavigationManager Navigator { get; set; } = default!;
    private MudDrawer Menu { get; set; } = default!;
    private Task OnMenuExternalChanged(bool stat)
    {
        Dispatcher.Dispatch(stat ? new MainMenuOpenAction() : new MainMenuCloseAction());
        return Task.CompletedTask;
    }
    protected override Task OnInitializedAsync()
    {
        var loadTeachingMenu = new TeachingGetAction();
        Dispatcher.Dispatch(loadTeachingMenu);
        return base.OnInitializedAsync();
    }
    private void AutoClose(string href)
    {

        Dispatcher.Dispatch(new MainMenuCloseAction());
        Navigator.NavigateTo(href);
    }
}