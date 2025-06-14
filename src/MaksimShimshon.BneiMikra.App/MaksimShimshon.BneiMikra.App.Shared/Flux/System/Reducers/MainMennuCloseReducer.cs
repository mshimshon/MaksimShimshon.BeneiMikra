using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.System.Reducers;
internal class MainMennuCloseReducer : Reducer<MainMenuState, MainMenuCloseAction>
{
    public override MainMenuState Reduce(MainMenuState state, MainMenuCloseAction action)
        => state with { IsOpened = false };
}
