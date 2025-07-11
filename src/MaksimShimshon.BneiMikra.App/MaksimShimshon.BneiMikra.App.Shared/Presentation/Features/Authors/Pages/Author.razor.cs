using MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Authors.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Authors.Pages;
public partial class Author
{
    [Parameter] public string Id { set; get; }
    private AuthorViewModel _viewModel = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<AuthorViewModel>(() => this, ShouldUpdate);
        _viewModel = articleVMHook.GetViewModel<AuthorViewModel>()!;
        await _viewModel.LoadAsync(Id);
    }
    private async Task ShouldUpdate() => await InvokeAsync(StateHasChanged);

}
