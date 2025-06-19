using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
public record ArticleLiteResponse : BaseEntityResponse
{
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public string Locale { get; set; } = default!;
    public AuthorLiteResponse Author { get; set; } = default!;
}
