using Fluxor.Blazor.Web.Components;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Stores;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class AuthorPage : FluxorComponent
{
    [Parameter] public string Id { get; set; } = default!;
    [Inject] public IState<AuthorViewState> ViewState { get; set; } = default!;
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
}
