using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;
using Strapi.Net;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class AuthorReadRepository : IAuthorReadRepository
{
    private readonly IStrapiClient _strapiClient;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;
    private readonly ICoreMap _coreMap;

    public AuthorReadRepository(
        IStrapiClient strapiClient,
        IResourceProvider<ApplicationResource> appResourceProvider,
        ICoreMap coreMap)
    {
        _strapiClient = strapiClient;
        _appResourceProvider = appResourceProvider;
        _coreMap = coreMap;
    }
    public async Task<AuthorEntity?> GetById(string id)
    {
        var result = await _strapiClient.GetAsync<AuthorResponse>($"authors/{id}");
        if (result == default)
            throw new AppUnknownException("ApiUnknownException", _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        if (result.Error != default)
            throw new AppApiException(new ValidationErrorEntity() { Code = result.Error.Name, Message = result.Error.Message });
        if (result.Data != default)
        {
            return await _coreMap.MapToAsync<AuthorResponse, AuthorEntity>(result.Data.First());
        }
        return default;
    }
}
