using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Actions;
public record AuthorGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }
}
