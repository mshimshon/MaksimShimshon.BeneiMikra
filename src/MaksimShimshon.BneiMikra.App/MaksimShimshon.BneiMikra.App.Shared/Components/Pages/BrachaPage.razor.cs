using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Stores;
using Microsoft.AspNetCore.Components;
using StatePulse.Net.Blazor;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class BrachaPage : ComponentBase
{
    [Parameter] public string Id { get; set; } = default!;
    [Inject] IPulse Pulsar { get; set; } = default!;
    [Inject] private BrachaViewState BrachaState => Pulsar.StateOf<BrachaViewState>(this);
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;

    protected override async Task OnParametersSetAsync()
    {
        await Dispatcher.Prepare(() => new BrachaGetOneAction(Id)).DispatchAsync();
    }
}
