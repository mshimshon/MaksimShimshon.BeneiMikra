using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
internal class TanakhReferencePrintViewModel
{
    private readonly ISwizzleViewModel _swizzleViewModel;
    public bool IsLoading { get; set; }

    public TanakhVerseEntity? TanakhVerse { get; set; }
    public TanakhReferencePrintViewModel(
        ISwizzleViewModel swizzleViewModel
        )
    {
        _swizzleViewModel = swizzleViewModel;
    }

    public Task Initialize(string bookName, int chapiter, int verse)
    {
        IsLoading = true;
        //TODO: Load From Repository
    }
}
