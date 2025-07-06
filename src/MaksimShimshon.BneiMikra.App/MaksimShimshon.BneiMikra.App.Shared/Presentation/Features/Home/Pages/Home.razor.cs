using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Home.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Home.Pages;
public partial class Home
{
    private HomeViewModel _viewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;

    [SupplyParameterFromQuery(Name = "cat")]
    public string? Category { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var articleVMHook = SwizzleFact
            .CreateOrGet<HomeViewModel>(() => this, ShouldUpdate);
        _viewModel = articleVMHook.GetViewModel<HomeViewModel>()!;

    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);
    protected override async Task OnParametersSetAsync()
    {
        _viewModel.Category = Category;
        await _viewModel.LoadAsync();
    }
}
