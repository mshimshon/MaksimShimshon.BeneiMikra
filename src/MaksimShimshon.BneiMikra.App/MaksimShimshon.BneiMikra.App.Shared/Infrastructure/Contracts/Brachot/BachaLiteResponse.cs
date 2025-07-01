using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot;
internal record BrachaLiteResponse : BaseResponse
{
    public string Locale { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Gender { get; set; } = default!;
}
