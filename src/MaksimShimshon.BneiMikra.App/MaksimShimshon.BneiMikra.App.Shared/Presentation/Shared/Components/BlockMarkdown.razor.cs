using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class BlockMarkdown
{
    [Parameter] public string Body { get; set; } = default!;
    private BlockMarkdownViewModel ViewModel { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<BlockMarkdownViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));
        ViewModel = vmHook.GetViewModel<BlockMarkdownViewModel>()!;
    }
}
