using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Bracha.Contracts.Responses;
public record BrachaLiteResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Name { get; set; } = default!;
}
