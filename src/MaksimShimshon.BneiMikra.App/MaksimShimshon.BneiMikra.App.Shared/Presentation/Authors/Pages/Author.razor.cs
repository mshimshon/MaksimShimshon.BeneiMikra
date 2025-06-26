using MaksimShimshon.BneiMikra.App.Shared.Presentation.Authors.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Authors.Pages;
public partial class Author
{
    [Parameter] public string Id { set; get; }
    private AuthorViewModel _viewModel = default!;
    protected override async Task OnInitializedAsync()
    {
        var articleVMHook = SwizzleFact
            .CreateOrGet<AuthorViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));
        _viewModel = articleVMHook.GetViewModel<AuthorViewModel>()!;
        await _viewModel.LoadAsync(Id);
    }
}
