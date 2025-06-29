using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Brachot.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Brachot.ViewModels;
internal class BrachotViewModel
{
    private readonly IStatePulse _statePulse;
    private readonly ISwizzleViewModel _swizzleViewModel;
    private readonly IDispatcher _dispatcher;
    public bool IsLoading => ListingState.IsLoading;
    public BrachaListingState ListingState => _statePulse.StateOf<BrachaListingState>(() => this, OnStateChanged);
    public BrachotViewModel(
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

    public async Task LoadAsync()
    {
        await _dispatcher.Prepare<BrachaGetAction>().DispatchAsync();

    }
}
