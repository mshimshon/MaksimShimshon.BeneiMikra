using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class ArticlePage : FluxorComponent
{
    [Parameter]
    public string Id { get; set; } = default!;

    [Inject] private IState<ArticleViewState> ArticleState { get; set; } = default!;
    [Inject] IDispatcher Dispatcher { get; set; } = default!;
    protected override Task OnInitializedAsync()
    {
        var action = new ArticleGetOneAction(Id);
        Dispatcher.Dispatch(action);
        return base.OnInitializedAsync();
    }
}
