using MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class AuthorReadRepository : IAuthorReadRepository
{
    public Task<AuthorEntity> GetById(string id) => throw new NotImplementedException();
}
