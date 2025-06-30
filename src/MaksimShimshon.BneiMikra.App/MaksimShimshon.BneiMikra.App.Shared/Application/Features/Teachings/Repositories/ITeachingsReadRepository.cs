using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Repositories;
public interface ITeachingsReadRepository
{
    Task<SearchResultEntity<ArticleEntity>?> Search(int page = 1);
}
