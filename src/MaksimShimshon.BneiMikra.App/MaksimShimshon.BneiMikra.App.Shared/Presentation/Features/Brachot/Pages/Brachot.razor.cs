using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.Pages;
public partial class Brachot
{
    private BrachotViewModel _viewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<BrachotViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));
        _viewModel = articleVMHook.GetViewModel<BrachotViewModel>()!;
        await _viewModel.LoadAsync();
    }
}
