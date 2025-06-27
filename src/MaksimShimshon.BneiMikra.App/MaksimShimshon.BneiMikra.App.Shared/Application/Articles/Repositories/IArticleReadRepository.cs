using MaksimShimshon.BneiMikra.App.Shared.Domain.Articles.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Repositories;
public interface IArticleReadRepository
{
    Task<ArticleEntity> GetById(string id);
    Task<SearchResultEntity<ArticleEntity>> GetMany();
}
