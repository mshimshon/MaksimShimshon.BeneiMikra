using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class BrachaPage : FluxorComponent
{
    [Parameter]
    public string Id { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    [Inject] private IState<BrachaViewState> BrachaState { get; set; } = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override Task OnParametersSetAsync()
    {
        Dispatcher.Dispatch(new BrachaGetOneAction(Id));
        return base.OnParametersSetAsync();
    }
}
