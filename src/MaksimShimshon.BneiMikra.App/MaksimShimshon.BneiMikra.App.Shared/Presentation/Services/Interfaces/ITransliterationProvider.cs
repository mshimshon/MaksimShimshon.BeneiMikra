using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Implementation.Transliterator;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Interfaces;

public interface ITransliterationProvider
{
    string Transliterate(string hebrewText, TransliteratorSchema? schema = null);
}
