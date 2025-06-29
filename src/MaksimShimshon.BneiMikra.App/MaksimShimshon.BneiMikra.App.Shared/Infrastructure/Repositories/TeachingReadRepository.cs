using MaksimShimshon.BneiMikra.App.Shared.Application.Teachings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class TeachingReadRepository : ITeachingsReadRepository
{
    public Task<SearchResultEntity<ArticleEntity>?> Search(int page = 1)
        => throw new NotImplementedException();
}
