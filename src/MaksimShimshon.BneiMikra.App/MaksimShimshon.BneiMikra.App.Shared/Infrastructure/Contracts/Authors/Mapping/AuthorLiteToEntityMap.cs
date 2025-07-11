using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors.Mapping;
internal class AuthorLiteToEntityMap : ICoreMapHandler<AuthorLiteResponse, AuthorEntity>
{
    public AuthorEntity Handler(AuthorLiteResponse data, ICoreMap alsoMap) => new()
    {
        Id = data.DocumentId,
        Email = data.Email,
        Name = data.Name,
    };

}
