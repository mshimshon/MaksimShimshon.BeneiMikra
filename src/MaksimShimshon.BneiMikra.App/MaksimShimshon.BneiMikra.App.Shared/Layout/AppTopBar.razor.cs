using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Layout;
public partial class AppTopBar : FluxorComponent
{
    //[Inject] private IServiceProvider PRovider { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    [Inject] private IState<MainMenuState> MainMenuStore { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {

        await base.OnInitializedAsync();
    }
    private Task OnMenuClicked()
    {
        var action = new MainMenuToggleAction();
        //Dispatcher.Dispatch(action);
        return Task.CompletedTask;
    }
}
