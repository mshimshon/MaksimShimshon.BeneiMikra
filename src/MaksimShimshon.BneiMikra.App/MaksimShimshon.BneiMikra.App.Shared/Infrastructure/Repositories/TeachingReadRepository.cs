using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Teachings;
using Strapi.Net;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class TeachingReadRepository : ITeachingsReadRepository
{
    private readonly IStrapiClient _strapiClient;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;
    private readonly ICoreMap _coreMap;

    public TeachingReadRepository(
        IStrapiClient strapiClient,
        IResourceProvider<ApplicationResource> appResourceProvider,
        ICoreMap coreMap)
    {
        _strapiClient = strapiClient;
        _appResourceProvider = appResourceProvider;
        _coreMap = coreMap;
    }
    public async Task<SearchResultEntity<TeachingEntity>?> Search(int page = 1)
    {
        var query = StrapiQueryBuilder.Create();
        query.Populate("article");
        query.Paginate(page, 10);
        string url = query.ToQueryString("teachings");
        var result = await _strapiClient.GetAsync<TeachingResponse>(url);
        if (result == default)
            throw new AppUnknownException("ApiUnknownException", _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        if (result.Error != default)
            throw new AppApiException(new ValidationErrorEntity()
            {
                Code = result.Error.Name,
                Message = result.Error.Message
            });

        if (result.Data != default)
        {
            return await _coreMap.MapToAsync<StrapiResponse<TeachingResponse>, SearchResultEntity<TeachingEntity>>(result);
        }
        return default;
    }
}
