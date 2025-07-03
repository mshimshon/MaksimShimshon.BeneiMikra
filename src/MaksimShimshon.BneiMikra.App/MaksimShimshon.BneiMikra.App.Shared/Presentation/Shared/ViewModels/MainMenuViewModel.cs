using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class MainMenuViewModel
{
    private readonly IStatePulse _statePulse;
    private readonly IDispatcher _dispatcher;
    private readonly ISwizzleViewModel _swizzleViewModel;
    public MainMenuState MainMenuState => _statePulse.StateOf<MainMenuState>(() => this, StateHasChanged);
    public TeachingState TeachingState => _statePulse.StateOf<TeachingState>(() => this, StateHasChanged);
    public MainMenuViewModel(
        IStatePulse statePulse,
        IDispatcher dispatcher, ISwizzleViewModel swizzleViewModel
        )
    {
        _statePulse = statePulse;
        _dispatcher = dispatcher;
        _swizzleViewModel = swizzleViewModel;
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
