using MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.System.Reducers;
internal class MainMennuCloseReducer : IReducer<MainMenuState, MainMenuCloseAction>
{
    public Task<MainMenuState> ReduceAsync(MainMenuState state, MainMenuCloseAction action)
        => Task.FromResult(state with { IsOpened = false });
}
