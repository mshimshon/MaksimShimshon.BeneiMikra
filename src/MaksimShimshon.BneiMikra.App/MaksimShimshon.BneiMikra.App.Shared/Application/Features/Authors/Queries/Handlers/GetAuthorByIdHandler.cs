using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Queries.Handlers;
internal class GetAuthorByIdHandler : IRequestHandler<GetAuthorByIdQuery, AuthorEntity>
{
    private readonly IAuthorReadRepository _authorReadRepository;

    public GetAuthorByIdHandler(
        IAuthorReadRepository authorReadRepository
        )
    {
        _authorReadRepository = authorReadRepository;
    }
    public async Task<AuthorEntity> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        => await _authorReadRepository.GetById(request.Id);
}
