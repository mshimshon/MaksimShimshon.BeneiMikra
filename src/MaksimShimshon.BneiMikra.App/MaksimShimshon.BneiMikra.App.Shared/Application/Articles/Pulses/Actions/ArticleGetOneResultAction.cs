using MaksimShimshon.BneiMikra.App.Shared.Domain.Articles.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
public record ArticleGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public ArticleEntity? Result { get; set; }
}
