using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Application.Exceptions;
using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Tanakh.Respositories;
using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;
using Strapi.Net;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class TanakhReadRepository : ITanakhReadRepository
{
    private readonly IStrapiClient _strapiClient;
    private readonly ICoreMap _coreMap;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;

    public TanakhReadRepository(
        IStrapiClient strapiClient,
        ICoreMap coreMap,
        IResourceProvider<ApplicationResource> appResourceProvider
        )
    {
        _strapiClient = strapiClient;
        _coreMap = coreMap;
        _appResourceProvider = appResourceProvider;
    }
    public Task<SearchResultEntity<TanakhReferenceEntity>?> GetChapiter(TanakhBook book, int chapiter) => throw new NotImplementedException();
    public async Task<TanakhVerseEntity?> GetVerse(TanakhBook book, int chapiter, int verse)
    {
        var query = StrapiQueryBuilder.Create()
        .Filter<TanakhVerseResponse>(p => p.Book, p => p.ToLower(), Strapi.Net.Enums.StrapiFilterOperator.Equal, book.ToString())
        .Filter<TanakhVerseResponse>(p => p.Chapiter, p => p.ToLower(), Strapi.Net.Enums.StrapiFilterOperator.Equal, chapiter.ToString())
        .Filter<TanakhVerseResponse>(p => p.Verse, p => p.ToLower(), Strapi.Net.Enums.StrapiFilterOperator.Equal, verse.ToString())
        .ToQueryString("torahs");
        var result = await _strapiClient.GetAsync<TanakhVerseResponse>(query);


        if (result == default)
            throw new AppUnknownException("ApiUnknownException", _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        if (result.Error != default)
            throw new AppApiException(new ValidationErrorEntity() { Code = result.Error.Name, Message = result.Error.Message });
        if (result.Data != default)
        {
            return _coreMap.MapTo<TanakhVerseResponse, TanakhVerseEntity>(result.Data.First());
        }
        return default;
    }
    public Task<SearchResultEntity<TanakhReferenceEntity>?> GetWholeBook(TanakhBook book) => throw new NotImplementedException();
}
