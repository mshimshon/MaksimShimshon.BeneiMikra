using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Reducers;
internal class GetAppLocalSettingsResultReducer : IReducer<AppSettingsState, GetAppLocalSettingsResultAction>
{
    public async Task<AppSettingsState> ReduceAsync(AppSettingsState state, GetAppLocalSettingsResultAction action)
        => await Task.FromResult(state with
        {
            LocalSettings = action.Result
        });
}
