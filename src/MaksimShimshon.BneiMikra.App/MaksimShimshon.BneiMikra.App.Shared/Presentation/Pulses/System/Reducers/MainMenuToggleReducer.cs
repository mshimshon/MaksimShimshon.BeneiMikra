using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Reducers;
internal class MainMenuToggleReducer : IReducer<MainMenuState, MainMenuToggleAction>
{
    public Task<MainMenuState> ReduceAsync(MainMenuState state, MainMenuToggleAction action)
        => Task.FromResult(state with
        {
            IsOpened = !state.IsOpened
        });
}
