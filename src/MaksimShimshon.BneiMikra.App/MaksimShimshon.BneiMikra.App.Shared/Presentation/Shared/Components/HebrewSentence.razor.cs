using MaksimShimshon.BneiMikra.App.Shared.Contracts.Tanakh.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class HebrewSentence : ComponentBase
{
    [Parameter] public string Hebrew { get; set; } = default!;
    [Parameter] public string? Translation { get; set; }
    [Parameter] public List<TanakhReferenceResponse>? ScripturalReferences { get; set; }
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;

    private HebrewSentenceViewModel ViewModel { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<HebrewSentenceViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));

        ViewModel = vmHook.GetViewModel<HebrewSentenceViewModel>()!;
        ViewModel.Hebrew = Hebrew;
        await ViewModel.Initialize();
    }
}
