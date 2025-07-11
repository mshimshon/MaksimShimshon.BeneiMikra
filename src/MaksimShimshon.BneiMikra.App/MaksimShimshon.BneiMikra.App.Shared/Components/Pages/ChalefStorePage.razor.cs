using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.ValueObjects;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class ChalefStorePage
{
    private TanakhReferenceEntity CreateTanakhRef(TanakhBook book, int chapiter, int verse) =>
        new TanakhReferenceEntity()
        {
            Reference = new BookReference(book, chapiter, verse),
            Note = "Test Note"
        };
}
