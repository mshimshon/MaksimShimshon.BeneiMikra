using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class HebrewSentence : ComponentBase
{
    [Parameter] public string Hebrew { get; set; } = default!;
    [Parameter] public string? Translation { get; set; }
    [Parameter] public List<TanakhReferenceEntity>? ScripturalReferences { get; set; }
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;

    private HebrewSentenceViewModel ViewModel { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<HebrewSentenceViewModel>(() => this, ShouldUpdate);

        ViewModel = vmHook.GetViewModel<HebrewSentenceViewModel>()!;
        ViewModel.Hebrew = Hebrew;
        await ViewModel.Initialize();
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);
}
