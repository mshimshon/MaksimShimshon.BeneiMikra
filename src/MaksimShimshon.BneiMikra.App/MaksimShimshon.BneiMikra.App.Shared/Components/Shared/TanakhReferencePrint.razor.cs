using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.TanakhReferences.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class TanakhReferencePrint : FluxorComponent
{
    [Parameter]
    public string BookName { get; set; } = default!;

    [Parameter]
    public int Chapiter { get; set; }

    [Parameter]
    public int Verse { get; set; }

    [Parameter]
    public string? Note { get; set; }
    [Inject] public IState<TanakhViewState> State { get; set; } = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    [Inject] private ITransliterationProvider TransliterationProvider { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {
        var action = new TanakhGetOneAction(BookName, Chapiter) { Verse = Verse };
        Dispatcher.Dispatch(action);
        return base.OnInitializedAsync();
    }
}
