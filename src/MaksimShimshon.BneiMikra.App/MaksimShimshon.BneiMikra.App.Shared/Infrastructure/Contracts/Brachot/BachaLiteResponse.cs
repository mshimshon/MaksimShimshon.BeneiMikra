using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot;
public record BrachaLiteResponse : BaseResponse
{
    public string Locale { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Gender { get; set; } = default!;
}
