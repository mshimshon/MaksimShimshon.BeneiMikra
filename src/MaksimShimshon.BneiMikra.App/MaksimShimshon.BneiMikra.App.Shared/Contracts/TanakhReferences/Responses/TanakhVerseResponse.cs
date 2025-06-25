using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.TanakhReferences.Responses;
public record TanakhVerseResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Hebrew { get; set; } = default!;
    public string Transliteration { get; set; } = default!;
    public string Book { get; set; } = default!;
    public int Chapiter { get; set; }
    public int Verse { get; set; }

    public string? Translated { get; set; }
    public string? TranslationSource { get; set; }

}
