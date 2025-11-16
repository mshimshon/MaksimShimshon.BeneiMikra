using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks;
public partial class BlockMarkdown
{
    private readonly ISwizzleViewModel _swizzleViewModel;

    [Parameter] public string Body { get; set; } = default!;
    private BlockMarkdownViewModel ViewModel { get; set; } = default!;

    public BlockMarkdown(ISwizzleViewModel swizzleViewModel)
    {
        _swizzleViewModel = swizzleViewModel;
    }
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<BlockMarkdownViewModel>(() => this, ShouldUpdate);
        ViewModel = vmHook.GetViewModel<BlockMarkdownViewModel>()!;

        ViewModel.Body = Body;
        await ViewModel.Initialize();
    }

    private async Task ShouldUpdate() => await _swizzleViewModel.SpreadChanges(() => this);

}
