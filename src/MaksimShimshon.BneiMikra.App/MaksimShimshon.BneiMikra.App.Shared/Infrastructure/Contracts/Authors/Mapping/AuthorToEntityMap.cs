using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors.Mapping;
internal class AuthorToEntityMap : ICoreMapHandler<AuthorResponse, AuthorEntity>
{
    public AuthorEntity Handler(AuthorResponse data, ICoreMap alsoMap) => new()
    {
        Email = data.Email,
        Id = data.DocumentId,
        Name = data.Name,
        InfoParts = data.Biography != default ? alsoMap.MapTo<ArticleResponse, AuthorEntity>(data.Biography).InfoParts : new List<BlockComponent>()
    };

}
