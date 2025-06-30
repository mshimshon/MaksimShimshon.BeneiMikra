using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;
internal record AuthorLiteResponse : BaseResponse
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
}
