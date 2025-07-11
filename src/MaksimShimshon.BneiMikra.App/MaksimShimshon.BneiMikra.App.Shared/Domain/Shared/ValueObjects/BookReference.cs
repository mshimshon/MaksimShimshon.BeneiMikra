using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.ValueObjects;
public record BookReference
{
    public TanakhBook Book { get; }
    public int Chapiter { get; }
    public int Verse { get; }

    public BookReference(TanakhBook book, int chapiter, int verse)
    {
        Book = book;
        Chapiter = chapiter;
        if (chapiter <= 0) throw new ArgumentException("Chapiter cannot be 0 or below.");
        Verse = verse;
        if (verse < 0) throw new ArgumentException("Verse cannot be 0 or below.");
    }
}
