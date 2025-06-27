using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Actions;
public record AuthorGetOneResultAction : IAction
{
    public bool IsLoading { get; set; }
    public AuthorEntity? Result { get; set; }
}
