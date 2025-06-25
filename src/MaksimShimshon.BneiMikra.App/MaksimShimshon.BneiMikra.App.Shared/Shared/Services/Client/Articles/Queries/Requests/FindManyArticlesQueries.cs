using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Articles.Queries.Requests;
public record FindManyArticlesQueries : IRequest<List<ArticleLiteResponse>>
{

    public List<string> Categories { get; } = new();
    public int Page { get; init; } = 0;
    public int PageSize { get; init; } = 10;
}
