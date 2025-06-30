using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.ViewModels;
internal class BrachaViewModel
{
    private readonly IStatePulse _statePulse;
    private readonly ISwizzleViewModel _swizzleViewModel;

    public string Id { get; set; } = default!;
    public bool IsLoading => ViewState.IsLoading;
    public BrachaViewState ViewState => _statePulse.StateOf<BrachaViewState>(() => this, OnStateChanged);
    public BrachaViewModel(
        IStatePulse statePulse,
        ISwizzleViewModel swizzleViewModel
        )
    {
        _statePulse = statePulse;
        _swizzleViewModel = swizzleViewModel;
    }

    public async Task OnStateChanged()
    {
        await _swizzleViewModel.SpreadChanges(() => this);
    }

    public Task LoadAsync(string id)
    {
        return Task.CompletedTask;
    }
}
