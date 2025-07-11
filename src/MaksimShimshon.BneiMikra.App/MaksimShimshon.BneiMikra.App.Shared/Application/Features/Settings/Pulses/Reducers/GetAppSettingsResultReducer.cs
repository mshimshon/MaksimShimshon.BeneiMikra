using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Reducers;
internal class GetAppSettingsResultReducer : IReducer<AppSettingsState, GetAppSettingsResultAction>
{
    public async Task<AppSettingsState> ReduceAsync(AppSettingsState state, GetAppSettingsResultAction action)
        => await Task.FromResult(state with
        {
            Settings = action.Result
        });
}
