using MaksimShimshon.BneiMikra.App.Shared.Domain.Settings.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Repositories;
public interface IAppSettingsReadRepository
{
    Task<AppSettingsEntity> LoadSettings();
    Task<AppLocalSettingsEntity> LoadLocalSettings();
}
