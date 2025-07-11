using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Queries;
public record GetAuthorByIdQuery(string Id) : IRequest<AuthorEntity>
{
}
