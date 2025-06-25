using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.System.Reducers;
internal class MainMenuOpenReducer : IReducer<MainMenuState, MainMenuOpenAction>
{
    public Task<MainMenuState> ReduceAsync(MainMenuState state, MainMenuOpenAction action)
        => Task.FromResult(state with { IsOpened = true });
}
