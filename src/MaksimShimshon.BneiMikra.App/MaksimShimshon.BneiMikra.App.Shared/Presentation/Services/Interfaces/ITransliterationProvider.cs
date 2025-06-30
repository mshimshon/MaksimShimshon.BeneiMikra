using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Implementation.Transliterator;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Interfaces;
public interface ITransliterationProvider
{
    Task<string> TransliterateAsync(string hebrewText, TransliteratorSchema? schema = default);
    string Transliterate(string hebrewText, TransliteratorSchema? schema = null);
}
