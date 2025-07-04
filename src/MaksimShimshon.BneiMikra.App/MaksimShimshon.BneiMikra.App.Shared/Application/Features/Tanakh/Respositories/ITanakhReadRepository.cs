using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Tanakh.Respositories;
public interface ITanakhReadRepository
{
    Task<TanakhReferenceEntity?> GetVerse(TanakhBook book, int chapiter, int verse);
    Task<SearchResultEntity<TanakhReferenceEntity>?> GetChapiter(TanakhBook book, int chapiter);
    Task<SearchResultEntity<TanakhReferenceEntity>?> GetWholeBook(TanakhBook book);
}
