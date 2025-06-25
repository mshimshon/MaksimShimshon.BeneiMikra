using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Reducers;
internal class MainMenuToggleReducer : IReducer<MainMenuState, MainMenuToggleAction>
{
    public Task<MainMenuState> ReduceAsync(MainMenuState state, MainMenuToggleAction action)
        => Task.FromResult(state with
        {
            IsOpened = !state.IsOpened
        });
}
