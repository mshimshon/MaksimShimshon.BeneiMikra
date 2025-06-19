using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Actions;
public record AuthorGetOneResultAction
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }
}
