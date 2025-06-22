using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Stores;
using Microsoft.AspNetCore.Components;
using StatePulse.Net.Blazor;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class HomePage : ComponentBase
{
    [Inject] IPulse Pulsar { get; set; } = default!;
    [Inject] private ArticleSearchState LatestArticle => Pulsar.StateOf<ArticleSearchState>(this);
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnParametersSetAsync()
    {
        var action = new ArticleSearchAction(string.Empty, "publishedAt:desc");
        await Dispatcher.Prepare(() => action).DispatchAsync();
    }
}
