using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Data;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
public interface ITransliterationProvider
{
    Task<string> TransliterateAsync(string hebrewText, TransliteratorSchema? schema = default);
    string Transliterate(string hebrewText, TransliteratorSchema? schema = null);
}
