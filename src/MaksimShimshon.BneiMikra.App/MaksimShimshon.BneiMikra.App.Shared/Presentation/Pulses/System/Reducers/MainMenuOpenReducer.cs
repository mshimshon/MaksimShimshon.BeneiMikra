using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Pulses.System.Reducers;
internal class MainMenuOpenReducer : IReducer<MainMenuState, MainMenuOpenAction>
{
    public Task<MainMenuState> ReduceAsync(MainMenuState state, MainMenuOpenAction action)
        => Task.FromResult(state with { IsOpened = true });
}
