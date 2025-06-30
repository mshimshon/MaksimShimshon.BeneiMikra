using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Respositories;
public interface IAuthorReadRepository
{
    Task<AuthorEntity> GetById(string id);
}
