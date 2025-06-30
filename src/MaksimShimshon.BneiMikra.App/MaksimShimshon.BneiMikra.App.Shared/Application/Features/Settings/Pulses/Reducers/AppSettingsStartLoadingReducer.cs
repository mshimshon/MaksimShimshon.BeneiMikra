using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Reducers;
internal class AppSettingsStartLoadingReducer : IReducer<AppSettingsState, AppSettingsStartLoadingAction>
{
    public async Task<AppSettingsState> ReduceAsync(AppSettingsState state, AppSettingsStartLoadingAction action)
        => await Task.FromResult(state with
        {
            IsLoading = true
        });
}
