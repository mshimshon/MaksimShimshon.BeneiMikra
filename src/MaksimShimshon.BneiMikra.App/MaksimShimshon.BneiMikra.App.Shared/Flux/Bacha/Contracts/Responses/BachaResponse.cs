using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;
public record BrachaResponse : BrachaLiteResponse
{
    public string Hebrew { get; set; } = default!;
    public string Transliteration { get; set; } = default!;
    public string? Translated { get; set; }
    public List<TanakhReferenceResponse>? TanakhReferences { get; set; }
}
