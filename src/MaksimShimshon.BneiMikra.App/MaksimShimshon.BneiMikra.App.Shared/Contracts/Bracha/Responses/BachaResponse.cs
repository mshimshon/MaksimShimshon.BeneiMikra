using MaksimShimshon.BneiMikra.App.Shared.Contracts.Tanakh.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;
public record BrachaResponse : BrachaLiteResponse
{
    public string Hebrew { get; set; } = default!;
    public string Transliteration { get; set; } = default!;
    public string? Translated { get; set; }
    public List<TanakhReferenceResponse>? TanakhReferences { get; set; }
}
