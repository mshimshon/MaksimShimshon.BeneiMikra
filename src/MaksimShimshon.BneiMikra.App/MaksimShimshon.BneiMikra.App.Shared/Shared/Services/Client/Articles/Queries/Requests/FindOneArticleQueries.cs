using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Articles.Queries.Requests;
public record FindOneArticleQueries(string Id) : IRequest<ArticleResponse>
{
}
