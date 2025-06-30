using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class ArticleReadRepository : IArticleReadRepository
{

    public Task<ArticleEntity> GetById(string id)
        => throw new NotImplementedException();

    public Task<SearchResultEntity<ArticleEntity>> GetMany(string? keywords, string? category, string? sortBy, int page = 1)
        => throw new NotImplementedException();
}
