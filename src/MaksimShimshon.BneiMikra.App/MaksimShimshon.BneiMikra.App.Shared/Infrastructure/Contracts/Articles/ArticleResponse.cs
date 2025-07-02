using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
public record ArticleResponse : ArticleLiteResponse
{
    public List<StrapiBlockResponse>? Blocks { get; set; }
}
