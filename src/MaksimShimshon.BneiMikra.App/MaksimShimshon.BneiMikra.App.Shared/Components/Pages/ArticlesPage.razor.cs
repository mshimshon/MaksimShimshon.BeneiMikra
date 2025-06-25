using MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using StatePulse.Net.Blazor;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class ArticlesPage : ComponentBase
{
    [SupplyParameterFromQuery(Name = "cat")]
    public string? Category { get; set; }

    [SupplyParameterFromQuery(Name = "sort")]
    public string? SortBy { get; set; }

    [SupplyParameterFromQuery(Name = "q")]
    public string? Keywords { get; set; }
    [Inject] IStatePulse Pulsar { get; set; } = default!;
    ArticleSearchState SearchState => Pulsar.StateOf<ArticleSearchState>(this);
    [Inject] IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnParametersSetAsync()
    {
        var action = new ArticleSearchAction(Keywords ?? string.Empty, SortBy ?? string.Empty)
        {

            Category = Category ?? default
        };
        await Dispatcher.Prepare(() => action).DispatchAsync();
    }

}
