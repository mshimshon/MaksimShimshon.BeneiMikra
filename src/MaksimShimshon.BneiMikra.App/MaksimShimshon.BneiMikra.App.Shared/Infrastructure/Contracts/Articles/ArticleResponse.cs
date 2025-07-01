using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;
internal record ArticleResponse : ArticleLiteResponse
{
    public List<StrapiBlockResponse>? Blocks { get; set; }
}
