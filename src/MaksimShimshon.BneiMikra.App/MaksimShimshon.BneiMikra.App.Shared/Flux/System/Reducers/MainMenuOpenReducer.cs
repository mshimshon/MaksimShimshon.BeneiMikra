using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.System.Reducers;
internal class MainMenuOpenReducer : Reducer<MainMenuState, MainMenuOpenAction>
{
    public override MainMenuState Reduce(MainMenuState state, MainMenuOpenAction action)
   => state with { IsOpened = true };
}
