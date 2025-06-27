using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class AppTopBarViewModel
{
    private readonly IDispatcher _dispatcher;
    private readonly ISwizzleViewModel _swizzleViewModel;
    public MainMenuState State { get; private set; }
    public AppTopBarViewModel(
        IStatePulse statePulse,
        IDispatcher dispatcher,
        ISwizzleViewModel swizzleViewModel
        )
    {
        _dispatcher = dispatcher;
        _swizzleViewModel = swizzleViewModel;
        State = statePulse.StateOf<MainMenuState>(() => this, OnStateChanged);
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
