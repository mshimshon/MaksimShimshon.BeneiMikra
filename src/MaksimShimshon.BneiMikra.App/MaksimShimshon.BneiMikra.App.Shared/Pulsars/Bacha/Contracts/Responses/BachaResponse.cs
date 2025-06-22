using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;
public record BrachaResponse : BrachaLiteResponse
{
    public string Hebrew { get; set; } = default!;
    public string Transliteration { get; set; } = default!;
    public string? Translated { get; set; }
    public List<TanakhReferenceResponse>? TanakhReferences { get; set; }
}
