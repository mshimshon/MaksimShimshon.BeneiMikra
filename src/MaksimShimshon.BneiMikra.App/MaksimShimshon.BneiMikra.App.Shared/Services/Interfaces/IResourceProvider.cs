using System.Globalization;
using System.Linq.Expressions;

namespace MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
public interface IResourceProvider<TEntity> where TEntity : class
{
    string GetString(string name, CultureInfo? cultureInfo = default);
    string GetString(Expression<Func<string>> prop, CultureInfo? cultureInfo = default);
    string GetString(Expression<Func<string>> prop, CultureInfo? cultureInfo = default, params string[] formatVars);
    string GetString(Expression<Func<string>> prop, params string[] formatVars);
}
