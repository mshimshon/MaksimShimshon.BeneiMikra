using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors.Mapping;
internal class AuthorToEntityMap : ICoreMapHandler<AuthorResponse, AuthorEntity>
{
    private readonly ICoreMap _coreMap;

    public AuthorToEntityMap(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }
    public AuthorEntity MapHandler(AuthorResponse data) => new()
    {
        Email = data.Email,
        Id = data.DocumentId,
        Name = data.Name,
        InfoParts = data.Biography != default ? _coreMap.MapTo<ArticleResponse, AuthorEntity>(data.Biography).InfoParts : new List<BlockComponent>()
    };

    public async Task<AuthorEntity> MapHandlerAsync(AuthorResponse data)
        => await Task.FromResult(MapHandler(data));
}
