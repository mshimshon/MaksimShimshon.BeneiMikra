using MaksimShimshon.BneiMikra.App.Shared.Domain.Settings.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Pulses.Actions;
public record GetAppSettingsResultAction : IAction
{
    public AppSettingsEntity? Result { get; init; }
}
