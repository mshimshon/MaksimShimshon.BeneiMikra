using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Articles.Repositories;
internal interface IArticleQueriesRepository
{
    Task<ArticleResponse> FindOne(string id, CancellationToken cancellationToken);
    Task<SearchResultResponse<ArticleLiteResponse>> FindMany(string )
}
