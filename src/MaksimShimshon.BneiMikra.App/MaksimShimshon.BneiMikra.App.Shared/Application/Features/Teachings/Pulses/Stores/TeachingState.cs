using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Teachings.Pulses.Stores;

public record TeachingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public SearchResultEntity<ArticleEntity>? Result { get; set; }

}
