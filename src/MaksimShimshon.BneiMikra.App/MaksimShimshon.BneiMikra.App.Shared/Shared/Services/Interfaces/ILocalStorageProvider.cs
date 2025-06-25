using Microsoft.Extensions.Configuration;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
public interface ILocalStorageProvider
{
    Task<TEntity?> Get<TEntity>(string key, CancellationToken cancellationToken = default) where TEntity : class;
    Task Set<TEntity>(string key, TEntity? entity, CancellationToken cancellationToken = default) where TEntity : class;
    Task<IConfiguration> Get(string key, CancellationToken cancellationToken = default);
}
