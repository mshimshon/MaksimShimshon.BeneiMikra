using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Actions;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class MainLayoutViewModel
{
    private readonly IDispatcher _dispatcher;

    public MainLayoutViewModel(IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
    }

    public async Task LoadAsync()
    {
        await _dispatcher.Prepare<TeachingGetAction>().DispatchAsync();
    }
}
