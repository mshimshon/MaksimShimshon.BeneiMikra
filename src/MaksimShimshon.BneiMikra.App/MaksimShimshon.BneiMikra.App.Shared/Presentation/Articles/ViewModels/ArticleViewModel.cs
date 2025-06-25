using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Stores;


namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Articles.ViewModels;
internal class ArticleViewModel
{
    private readonly IDispatcher _dispatcher;
    private readonly ISwizzleViewModel _swizzleViewModel;
    private readonly ArticleViewState _state;

    public bool IsLoading => _state.IsLoading;
    public ArticleViewState State => _state;
    public ArticleViewModel(IStatePulse pulsars, ISwizzleViewModel swizzleViewModel, IDispatcher dispatcher)
    {
        _dispatcher = dispatcher;
        _swizzleViewModel = swizzleViewModel;
        _state = pulsars.StateOf<ArticleViewState>(this, OnStateHasChanged);
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
