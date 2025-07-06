using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;


namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Articles.ViewModels;
internal class ArticleViewModel
{
    private readonly IDispatcher _dispatcher;
    private readonly IStatePulse _pulsars;
    private readonly ISwizzleViewModel _swizzleViewModel;

    public bool IsLoading => State.IsLoading;
    public ArticleViewState State => _pulsars.StateOf<ArticleViewState>(() => this, OnStateHasChanged);
    public ArticleViewModel(IStatePulse pulsars, ISwizzleViewModel swizzleViewModel, IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
        _pulsars = pulsars;
        _swizzleViewModel = swizzleViewModel;
    }

    public async Task LoadAsync(string id)
    {
        var action = new ArticleGetOneAction(id);
        await _dispatcher.Prepare(() => action).DispatchAsync();
    }

    public Task OnStateHasChanged()
    {
        _swizzleViewModel.SpreadChanges(() => this);
        return Task.CompletedTask;
    }
}
