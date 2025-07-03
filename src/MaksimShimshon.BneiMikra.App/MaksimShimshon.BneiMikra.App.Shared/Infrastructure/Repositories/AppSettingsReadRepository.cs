using MaksimShimshon.BneiMikra.App.Shared.Application.Features.Settings.Repositories;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Settings.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Repositories;
internal class AppSettingsReadRepository : IAppSettingsReadRepository
{
    public Task<AppLocalSettingsEntity> LoadLocalSettings() => throw new NotImplementedException();
    public Task<AppSettingsEntity> LoadSettings() => throw new NotImplementedException();
}
