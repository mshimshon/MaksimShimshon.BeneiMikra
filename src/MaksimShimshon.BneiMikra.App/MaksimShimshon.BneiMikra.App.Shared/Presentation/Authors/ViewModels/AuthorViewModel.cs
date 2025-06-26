using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Stores;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Authors.ViewModels;
internal class AuthorViewModel
{
    private readonly IStatePulse _statePulse;
    private readonly ISwizzleViewModel _swizzleViewModel;

    public string Id { get; set; } = default!;
    public AuthorViewState ViewState => _statePulse.StateOf<AuthorViewState>(() => this, OnStateChanged);
    public IResourceProvider<ApplicationResource> ApplicationResourceProvider { get; }
    public bool IsLoading => ViewState.IsLoading;
    public AuthorViewModel(
        IResourceProvider<ApplicationResource> applicationResourceProvider,
        IStatePulse statePulse,
        ISwizzleViewModel swizzleViewModel
        )
    {
        ApplicationResourceProvider = applicationResourceProvider;
        _statePulse = statePulse;
        _swizzleViewModel = swizzleViewModel;
    }

    public async Task OnStateChanged()
    {
        await _swizzleViewModel.SpreadChanges(() => this);
    }
    public Task LoadAsync(string id)
    {

        return Task.CompletedTask;
    }
}
