using MaksimShimshon.BneiMikra.App.Shared.Domain.Settings.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Stores;
public record AppSettingsState : IStateFeature
{
    public bool IsLoading { get; init; }
    public AppLocalSettingsEntity? LocalSettings { get; init; } = new();
    public AppSettingsEntity? Settings { get; init; }
}
