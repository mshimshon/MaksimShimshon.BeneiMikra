using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class BrachotPage : FluxorComponent
{
    [Inject] IState<BrachaListingState> ListingState { get; set; } = default!;
    [Inject] IDispatcher Dispatcher { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {
        Dispatcher.Dispatch(new BrachaGetAction());
        return base.OnInitializedAsync();
    }
}
