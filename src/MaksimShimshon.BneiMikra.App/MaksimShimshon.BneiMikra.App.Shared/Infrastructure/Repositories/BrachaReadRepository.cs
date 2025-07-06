using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Brachot;
using Strapi.Net;
using Strapi.Net.Dto;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class BrachaReadRepository : IBrachaReadRepository
{
    private readonly IStrapiClient _strapiClient;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;
    private readonly ICoreMap _coreMap;

    public BrachaReadRepository(IStrapiClient strapiClient,
        IResourceProvider<ApplicationResource> appResourceProvider,
        ICoreMap coreMap)
    {
        _strapiClient = strapiClient;
        _appResourceProvider = appResourceProvider;
        _coreMap = coreMap;
    }
    public async Task<BrachaEntity?> GetById(string id)
    {
        var result = await _strapiClient.GetAsync<BrachaResponse>($"blessings/{id}");
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
            return _coreMap.MapTo<BrachaResponse, BrachaEntity>(result.Data.First());
        }
        return default;
    }
    public async Task<SearchResultEntity<BrachaEntity>?> Search(string? keywords, string? sortBy, int page = 1)
    {
        var query = StrapiQueryBuilder.Create();

        if (!string.IsNullOrWhiteSpace(sortBy)) query.AddSort(sortBy);

        query.Paginate(page, 10);
        if (!string.IsNullOrWhiteSpace(keywords))
            query.Search(keywords);
        string url = query.ToQueryString("blessings");
        var result = await _strapiClient.GetAsync<BrachaResponse>(url);
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
            return _coreMap.MapTo<StrapiResponse<BrachaResponse>, SearchResultEntity<BrachaEntity>>(result);
        }
        return default;
    }
}
