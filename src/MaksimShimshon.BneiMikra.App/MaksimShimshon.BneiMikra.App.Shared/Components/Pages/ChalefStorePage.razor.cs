using MaksimShimshon.BneiMikra.App.Shared.Contracts.Tanakh.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Pages;
public partial class ChalefStorePage
{
    private TanakhReferenceResponse CreateTanakhRef(string book, int chapiter, int verse) =>
        new TanakhReferenceResponse() { Book = book, Chapiter = chapiter, Verse = verse, Note = "Test Note" };
}
