using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class ArticlesPage : FluxorComponent
{
    [SupplyParameterFromQuery(Name = "cat")]
    public string? Category { get; set; }

    [SupplyParameterFromQuery(Name = "sort")]
    public string? SortBy { get; set; }

    [SupplyParameterFromQuery(Name = "q")]
    public string? Keywords { get; set; }
    [Inject] IState<ArticleSearchState> SearchState { get; set; } = default!;
    [Inject] IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    protected override Task OnParametersSetAsync()
    {
        var action = new ArticleSearchAction(Keywords ?? string.Empty, SortBy ?? string.Empty)
        {

            Category = Category ?? default
        };
        Dispatcher.Dispatch(action);
        return Task.CompletedTask;
    }

}
