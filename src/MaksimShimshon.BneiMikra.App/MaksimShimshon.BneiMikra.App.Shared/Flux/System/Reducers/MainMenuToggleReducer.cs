using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.System.Reducers;
internal class MainMenuToggleReducer : Reducer<MainMenuState, MainMenuToggleAction>
{
    public override MainMenuState Reduce(MainMenuState state, MainMenuToggleAction action) => state with
    {
        IsOpened = !state.IsOpened
    };
}
