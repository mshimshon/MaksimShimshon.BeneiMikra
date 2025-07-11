using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class TanakhReferenceViewModel
{
    private readonly ISwizzleViewModel _swizzleViewModel;
    private readonly IResourceProvider<ApplicationResource> _appResource;
    public string BookName { get; private set; } = default!;
    public string BookNameShort { get; private set; } = default!;
    public string RefereneceName { get; private set; } = default!;
    public string ReferenceAbreviation { get; private set; } = default!;
    public TanakhReferenceEntity TanakhRef { get; set; } = default!;
    public TanakhReferenceViewModel(
        ISwizzleViewModel swizzleViewModel,
        IResourceProvider<ApplicationResource> appResource
        )
    {
        _swizzleViewModel = swizzleViewModel;
        _appResource = appResource;
    }
    public Task Initialize()
    {
        BookName = _appResource.GetString($"TanakhBook{TanakhRef.Reference.Book}");
        BookNameShort = _appResource.GetString($"TanakhBook{TanakhRef.Reference.Book}Short");
        RefereneceName = $"{BookName} {TanakhRef.Reference.Chapiter}:{TanakhRef.Reference.Verse}";
        ReferenceAbreviation = $"{BookNameShort} {TanakhRef.Reference.Chapiter}:{TanakhRef.Reference.Verse}";
        return Task.CompletedTask;
    }
}
