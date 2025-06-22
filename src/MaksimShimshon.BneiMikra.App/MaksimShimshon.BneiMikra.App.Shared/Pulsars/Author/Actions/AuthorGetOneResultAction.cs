using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Actions;
public record AuthorGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }
}
