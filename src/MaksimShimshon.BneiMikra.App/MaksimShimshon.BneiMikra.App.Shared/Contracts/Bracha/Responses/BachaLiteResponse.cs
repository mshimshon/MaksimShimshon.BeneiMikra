using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Bracha.Responses;
public record BrachaLiteResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Name { get; set; } = default!;
}
