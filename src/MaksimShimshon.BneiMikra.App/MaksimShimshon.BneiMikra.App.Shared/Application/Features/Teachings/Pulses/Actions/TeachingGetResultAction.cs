using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Actions;
public record TeachingGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public SearchResultEntity<TeachingEntity>? Result { get; set; }
}
