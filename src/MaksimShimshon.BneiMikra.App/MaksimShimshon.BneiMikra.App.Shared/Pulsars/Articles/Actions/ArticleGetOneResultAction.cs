using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
public record ArticleGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public ArticleResponse? Result { get; set; }
}
