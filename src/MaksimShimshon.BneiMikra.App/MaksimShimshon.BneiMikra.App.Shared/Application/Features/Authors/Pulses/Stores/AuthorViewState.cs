using MaksimShimshon.BneiMikra.App.Shared.Domain.Author.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Authors.Pulses.Stores;

public record AuthorViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public AuthorEntity? Author { get; set; }
}
