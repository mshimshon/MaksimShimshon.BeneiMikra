using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;

public record ArticleViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public ArticleEntity? Result { get; set; }
}
