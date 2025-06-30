using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Teachings;
internal record TeachingResponse : BaseResponse
{
    public string Locale { get; set; } = default!;
    public string Title { get; set; } = default!;
    public ArticleLiteResponse Article { get; set; } = default!;
}
