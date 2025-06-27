using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class MainMenuViewModel
{
    private readonly IDispatcher _dispatcher;
    private readonly ISwizzleViewModel _swizzleViewModel;
    public MainMenuState MainMenuState { get; private set; }
    public TeachingState TeachingState { get; private set; }
    public MainMenuViewModel(
        IStatePulse statePulse,
        IDispatcher dispatcher,
        ISwizzleViewModel swizzleViewModel
        )
    {
        _dispatcher = dispatcher;
        _swizzleViewModel = swizzleViewModel;
        MainMenuState = statePulse.StateOf<MainMenuState>(() => this, StateHasChanged);
        TeachingState = statePulse.StateOf<TeachingState>(() => this, StateHasChanged);
    }

    public async Task StateHasChanged()
    {
        await _swizzleViewModel.SpreadChanges(() => this);
    }

    public async Task OnMenuExternalChanged(bool stat)
    {
        if (stat)
            await _dispatcher.Prepare<MainMenuOpenAction>().DispatchAsync();
        else
            await _dispatcher.Prepare<MainMenuCloseAction>().DispatchAsync();
    }

    public async Task OnInitializedAsync()
    {
        await _dispatcher.Prepare<TeachingGetAction>().DispatchAsync();
    }

    public async Task CloseMenu()
    {
        await _dispatcher.Prepare<MainMenuCloseAction>().DispatchAsync();
    }
}
