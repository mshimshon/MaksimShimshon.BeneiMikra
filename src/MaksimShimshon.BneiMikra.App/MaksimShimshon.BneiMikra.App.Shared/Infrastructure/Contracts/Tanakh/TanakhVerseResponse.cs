using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;
public record TanakhVerseResponse : BaseResponse
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
