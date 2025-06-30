using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
internal record ArticleResponse : BaseResponse
{
    public string Title { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public string Locale { get; set; } = default!;
}
