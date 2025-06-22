using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
public record ArticleLiteResponse : BaseEntityResponse
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public string Locale { get; set; } = default!;
    public AuthorLiteResponse Author { get; set; } = default!;
}
