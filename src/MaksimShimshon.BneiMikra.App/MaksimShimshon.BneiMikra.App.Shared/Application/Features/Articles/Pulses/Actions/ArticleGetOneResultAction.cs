using MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
public record ArticleGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public ArticleEntity? Result { get; set; }
}
