using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Articles.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Articles.Pages;
public partial class Article : ComponentBase
{
    [Parameter] public string Id { set; get; }
    private ArticleViewModel _articleViewModel = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<ArticleViewModel>(() => this, ShouldUpdate);
        _articleViewModel = articleVMHook.GetViewModel<ArticleViewModel>()!;
        await _articleViewModel.LoadAsync(Id);
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);
}
