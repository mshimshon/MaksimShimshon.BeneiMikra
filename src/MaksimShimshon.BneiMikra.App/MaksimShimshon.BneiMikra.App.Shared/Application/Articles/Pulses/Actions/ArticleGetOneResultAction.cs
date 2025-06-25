using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
public record ArticleGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public ArticleResponse? Result { get; set; }
}
