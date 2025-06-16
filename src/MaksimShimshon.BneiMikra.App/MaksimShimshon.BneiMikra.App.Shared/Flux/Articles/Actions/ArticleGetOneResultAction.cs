using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
public record ArticleGetOneResultAction
{
    public bool IsLoading { get; set; }
    public ArticleResponse? Result { get; set; }
}
