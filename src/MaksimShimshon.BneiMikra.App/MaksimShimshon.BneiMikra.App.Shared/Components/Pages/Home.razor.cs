using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class Home : FluxorComponent
{
    [Inject] private IState<ArticleSearchState> LatestArticle { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    protected override Task OnParametersSetAsync()
    {
        var action = new ArticleSearchAction(string.Empty, "publishedAt:desc");
        Dispatcher.Dispatch(action);
        return Task.CompletedTask;
    }
}
