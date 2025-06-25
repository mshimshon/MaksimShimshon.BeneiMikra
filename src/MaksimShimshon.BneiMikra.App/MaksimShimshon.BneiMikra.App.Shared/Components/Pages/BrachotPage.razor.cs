using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Bacha.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using StatePulse.Net.Blazor;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class BrachotPage : ComponentBase
{
    [Inject] IStatePulse Pulsar { get; set; } = default!;
    [Inject] BrachaListingState ListingState => Pulsar.StateOf<BrachaListingState>(this);
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {
        Dispatcher.Prepare<BrachaGetAction>().DispatchAsync();
        return base.OnInitializedAsync();
    }
}
