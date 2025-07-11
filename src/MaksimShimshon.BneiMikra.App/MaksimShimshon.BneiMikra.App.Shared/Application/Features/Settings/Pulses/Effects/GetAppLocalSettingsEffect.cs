using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Repositories;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Effects;
internal class GetAppLocalSettingsEffect : IEffect<GetAppLocalSettingsAction>
{
    private readonly IAppSettingsReadRepository _appSettingsReadRepository;

    public GetAppLocalSettingsEffect(IAppSettingsReadRepository appSettingsReadRepository)
    {
        _appSettingsReadRepository = appSettingsReadRepository;
    }
    public async Task EffectAsync(GetAppLocalSettingsAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<AppSettingsStartLoadingAction>()
                .Await().DispatchAsync();
            var result = await _appSettingsReadRepository.LoadLocalSettings();
            await dispatcher.Prepare<GetAppLocalSettingsResultAction>()
                .With(p => p.Result, result)
                .DispatchAsync();
            await dispatcher.Prepare<AppSettingsStopLoadingAction>().DispatchAsync();
        }
        catch (Exception)
        {
            await dispatcher.Prepare<AppSettingsStopLoadingAction>().DispatchAsync();
        }
    }
}
