using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Tanakh.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class TanakhReferencePrintViewModel
{
    private readonly ISwizzleViewModel _swizzleViewModel;
    private readonly ITanakhReadRepository _tanakhReadRepository;

    public TanakhReferenceEntity? LoadedEntity { get; private set; }
    public bool IsLoading { get; set; }

    public TanakhVerseEntity? TanakhVerse { get; set; }
    public TanakhReferencePrintViewModel(
        ISwizzleViewModel swizzleViewModel,
        ITanakhReadRepository tanakhReadRepository
        )
    {
        _swizzleViewModel = swizzleViewModel;
        _tanakhReadRepository = tanakhReadRepository;
    }

    public async Task LoadAsync(TanakhBook bookName, int chapiter, int verse)
    {
        IsLoading = true;
        await _swizzleViewModel.SpreadChanges(() => this);
        LoadedEntity = await _tanakhReadRepository.GetVerse(bookName, chapiter, verse);
        IsLoading = false;
        await _swizzleViewModel.SpreadChanges(() => this);
    }
}
