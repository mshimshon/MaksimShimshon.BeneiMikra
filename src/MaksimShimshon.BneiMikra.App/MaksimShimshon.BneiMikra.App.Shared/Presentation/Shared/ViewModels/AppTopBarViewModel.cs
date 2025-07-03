using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class AppTopBarViewModel
{
    private readonly IStatePulse _statePulse;
    private readonly IDispatcher _dispatcher;
    private readonly ISwizzleViewModel _swizzleViewModel;
    public MainMenuState State => _statePulse.StateOf<MainMenuState>(() => this, OnStateChanged);
    public AppTopBarViewModel(
        IStatePulse statePulse,
        IDispatcher dispatcher,
        ISwizzleViewModel swizzleViewModel
        )
    {
        _statePulse = statePulse;
        _dispatcher = dispatcher;
        _swizzleViewModel = swizzleViewModel;
    }

    public async Task OnStateChanged()
    {
        await _swizzleViewModel.SpreadChanges(() => this);
    }

    public async Task OnMenuButtonClick()
    {
        await _dispatcher
            .Prepare<MainMenuToggleAction>()
            .DispatchAsync();
    }
}
