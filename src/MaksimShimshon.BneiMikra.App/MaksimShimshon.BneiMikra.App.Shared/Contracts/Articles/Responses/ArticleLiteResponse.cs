using MaksimShimshon.BneiMikra.App.Shared.Contracts.Author.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
public record ArticleLiteResponse : BaseEntityResponse
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public string Locale { get; set; } = default!;
    public AuthorLiteResponse Author { get; set; } = default!;
}
