using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class TanakhReferenceDialog : FluxorComponent
{
    [Parameter]
    public string BookName { get; set; } = default!;

    [Parameter]
    public int Chapiter { get; set; }

    [Parameter]
    public int Verse { get; set; }

    [Inject] public IState<TanakhViewState> State { get; set; } = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {

        return base.OnInitializedAsync();
    }
}
