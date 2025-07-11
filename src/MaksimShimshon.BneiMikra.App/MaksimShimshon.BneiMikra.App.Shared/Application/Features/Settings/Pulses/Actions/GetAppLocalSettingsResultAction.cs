using MaksimShimshon.BneiMikra.App.Shared.Domain.Settings.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
public record GetAppLocalSettingsResultAction : IAction
{
    public AppLocalSettingsEntity? Result { get; init; }
}
