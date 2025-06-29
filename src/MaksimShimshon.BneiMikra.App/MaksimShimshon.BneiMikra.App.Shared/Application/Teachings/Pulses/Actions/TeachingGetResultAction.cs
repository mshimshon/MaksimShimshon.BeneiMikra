using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Teachings.Pulses.Actions;
public record TeachingGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public SearchResultEntity<ArticleEntity>? Result { get; set; }
}
