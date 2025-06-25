using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Teachings.Responses;
public record TeachingResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Title { get; set; } = default!;
    public ArticleLiteResponse Article { get; set; } = default!;
}
