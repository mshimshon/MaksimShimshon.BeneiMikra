using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using StatePulse.Net.Blazor;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class AuthorPage : ComponentBase
{
    [Parameter] public string Id { get; set; } = default!;
    [Inject] IStatePulse Pulsar { get; set; } = default!;
    [Inject] public AuthorViewState ViewState => Pulsar.StateOf<AuthorViewState>(this);
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
}
