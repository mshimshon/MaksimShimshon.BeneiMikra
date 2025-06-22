using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Stores;
using Microsoft.AspNetCore.Components;
using StatePulse.Net.Blazor;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class ArticlePage : ComponentBase
{
    [Parameter]
    public string Id { get; set; } = default!;
    [Inject] IPulse Pulsar { get; set; } = default!;
    private ArticleViewState ArticleState => Pulsar.StateOf<ArticleViewState>(this);

    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {

        var action = new ArticleGetOneAction(Id);
        await Dispatcher.Prepare(() => action).DispatchAsync();
        await base.OnInitializedAsync();
    }
}
