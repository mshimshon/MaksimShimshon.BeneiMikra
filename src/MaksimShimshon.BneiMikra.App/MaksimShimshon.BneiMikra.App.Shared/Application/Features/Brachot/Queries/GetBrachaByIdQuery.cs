using MaksimShimshon.BneiMikra.App.Shared.Domain.Bracha.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Brachot.Queries;
public record GetBrachaByIdQuery(string Id) : IRequest<BrachaEntity>
{
}
