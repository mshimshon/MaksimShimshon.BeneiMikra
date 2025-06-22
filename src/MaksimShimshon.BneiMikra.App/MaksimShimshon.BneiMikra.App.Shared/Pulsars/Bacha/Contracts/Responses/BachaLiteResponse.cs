using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Bacha.Contracts.Responses;
public record BrachaLiteResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Name { get; set; } = default!;
}
