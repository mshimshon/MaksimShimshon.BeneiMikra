using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Layout;
public partial class MainMenu : FluxorComponent
{
    [Inject] private IState<MainMenuState> MainMenuStore { get; set; } = null!;
    [Inject] private IResourceProvider<ApplicationResource> ApplicationResourceProvider { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = null!;
    private MudDrawer Menu { get; set; } = default!;
    private Task OnMenuExternalChanged(bool stat)
    {
        Dispatcher.Dispatch(stat ? new MainMenuOpenAction() : new MainMenuCloseAction());
        return Task.CompletedTask;
    }
}