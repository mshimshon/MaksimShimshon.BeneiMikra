using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Features.Home.ViewModels;
internal class HomeViewModel
{
    private readonly ISwizzleViewModel _swizzleViewModel;
    private readonly IDispatcher _dispatcher;
    private readonly IStatePulse _statePulse;

    public ArticleSearchState LatestArticles => _statePulse.StateOf<ArticleSearchState>(() => this, OnStateChanged);
    public bool IsLoading => LatestArticles.IsLoading;
    public HomeViewModel(
        IStatePulse statePulse,
        ISwizzleViewModel swizzleViewModel,
        IDispatcher dispatcher
        )
    {
        _statePulse = statePulse;
        _swizzleViewModel = swizzleViewModel;
        _dispatcher = dispatcher;
    }

    private async Task OnStateChanged()
    {
        await _swizzleViewModel.SpreadChanges(() => this);
    }
    public async Task LoadAsync()
    {
        var action = new ArticleSearchAction()
        {
            SortBy = "publishedAt:desc",
        };
        await _dispatcher.Prepare(() => action).DispatchAsync();
    }
}
