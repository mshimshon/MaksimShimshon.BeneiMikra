using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class TanakhReferencePrint : ComponentBase
{
    [Parameter]
    public string BookName { get; set; } = default!;

    [Parameter]
    public int Chapiter { get; set; }

    [Parameter]
    public int Verse { get; set; }

    [Parameter]
    public string? Note { get; set; }

    private TanakhReferenceResponse? Result { get; set; }

    public bool IsLoading { get; set; } = true;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    [Inject] private ITransliterationProvider TransliterationProvider { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {
        var action = new TanakhGetOneAction(BookName, Chapiter) { Verse = Verse };
        Dispatcher.Dispatch(action);
        return base.OnInitializedAsync();
    }
}
