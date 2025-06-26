using MaksimShimshon.BneiMikra.App.Shared.Presentation.Home.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Home.Pages;
public partial class Home
{
    private HomeViewModel _viewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<HomeViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));
        _viewModel = articleVMHook.GetViewModel<HomeViewModel>()!;
        await _viewModel.LoadAsync();
    }
}
