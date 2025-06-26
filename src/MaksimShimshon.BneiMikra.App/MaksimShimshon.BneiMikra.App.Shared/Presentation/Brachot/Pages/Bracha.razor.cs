using MaksimShimshon.BneiMikra.App.Shared.Presentation.Brachot.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Brachot.Pages;
public partial class Bracha
{
    [Parameter] public string Id { set; get; }
    private BrachaViewModel _viewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<BrachaViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));
        _viewModel = articleVMHook.GetViewModel<BrachaViewModel>()!;
        await _viewModel.LoadAsync(Id);
    }
}
