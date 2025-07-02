using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
public record ArticleLiteResponse : BaseResponse
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public string Locale { get; set; } = default!;
    public AuthorLiteResponse? Author { get; set; }
    public CategoryResponse? Category { get; set; }
}
