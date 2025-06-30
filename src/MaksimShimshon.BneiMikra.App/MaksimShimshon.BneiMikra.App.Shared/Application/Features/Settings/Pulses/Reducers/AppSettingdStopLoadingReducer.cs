using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Reducers;
internal class AppSettingdStopLoadingReducer : IReducer<AppSettingsState, AppSettingsStopLoadingAction>
{
    public async Task<AppSettingsState> ReduceAsync(AppSettingsState state, AppSettingsStopLoadingAction action)
        => await Task.FromResult(state with
        {
            IsLoading = false
        });
}
