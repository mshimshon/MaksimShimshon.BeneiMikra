using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.ViewModels;
internal class BrachaViewModel
{
    private readonly IStatePulse _statePulse;
    private readonly ISwizzleViewModel _swizzleViewModel;
    private readonly IDispatcher _dispatcher;

    public string Id { get; set; } = default!;
    public bool IsLoading => ViewState.IsLoading;
    public BrachaViewState ViewState => _statePulse.StateOf<BrachaViewState>(() => this, OnStateChanged);
    public BrachaViewModel(
        IStatePulse statePulse,
        ISwizzleViewModel swizzleViewModel,
        IDispatcher dispatcher
        )
    {
        _statePulse = statePulse;
        _swizzleViewModel = swizzleViewModel;
        _dispatcher = dispatcher;
    }

    public async Task OnStateChanged()
    {
        await _swizzleViewModel.SpreadChanges(() => this);
    }

    public async Task LoadAsync(string id)
    {
        await _dispatcher.Prepare(() => new BrachaGetOneAction(id)).DispatchAsync();
    }
}
