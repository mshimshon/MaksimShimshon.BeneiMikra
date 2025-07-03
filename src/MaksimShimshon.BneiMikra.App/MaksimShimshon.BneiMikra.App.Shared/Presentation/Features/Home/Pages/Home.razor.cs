using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Home.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Home.Pages;
public partial class Home
{
    private HomeViewModel _viewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<HomeViewModel>(() => this, ShouldUpdate);
        _viewModel = articleVMHook.GetViewModel<HomeViewModel>()!;
        await _viewModel.LoadAsync();
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);

}
