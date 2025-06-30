using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Queries;
public record SearchBrachotQuery(string? Keywords, string? SortBy, int Page = 1) : IRequest<SearchResultEntity<BrachaEntity>> { }
