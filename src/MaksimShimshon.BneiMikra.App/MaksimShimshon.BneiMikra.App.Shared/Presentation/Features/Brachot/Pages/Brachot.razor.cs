﻿using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.Pages;
public partial class Brachot
{
    private BrachotViewModel _viewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<BrachotViewModel>(() => this, ShouldUpdate);
        _viewModel = articleVMHook.GetViewModel<BrachotViewModel>()!;
        await _viewModel.LoadAsync();
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);

}
