using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Repositories;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Effects;
internal class GetAppSettingsEffect : IEffect<GetAppSettingsAction>
{
    private readonly IAppSettingsReadRepository _appSettingsReadRepository;

    public GetAppSettingsEffect(IAppSettingsReadRepository appSettingsReadRepository)
    {
        _appSettingsReadRepository = appSettingsReadRepository;
    }
    public async Task EffectAsync(GetAppSettingsAction action, IDispatcher dispatcher)
    {
        try
        {
            await dispatcher.Prepare<AppSettingsStartLoadingAction>()
                .UsingSynchronousMode().DispatchAsync();
            var result = await _appSettingsReadRepository.LoadSettings();
            await dispatcher.Prepare<GetAppSettingsResultAction>()
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
