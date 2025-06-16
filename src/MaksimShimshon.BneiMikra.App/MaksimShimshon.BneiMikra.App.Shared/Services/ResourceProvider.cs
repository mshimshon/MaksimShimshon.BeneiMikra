using MaksimShimshon.BneiMikra.App.Shared.Extensions;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;

namespace MaksimShimshon.BneiMikra.App.Shared.Services;
internal class ResourceProvider<TResource> : IResourceProvider<TResource> where TResource : class
{
    private readonly ResourceManager _resourceManager;
    private readonly CultureInfo _cultureInfo;
    public ResourceProvider()
    {
        try
        {
            var property = typeof(TResource).GetProperty("ResourceManager", BindingFlags.Public | BindingFlags.Static);
            var value = property!.GetValue(null) as ResourceManager;
            _resourceManager = value!;
            _cultureInfo = new CultureInfo("en");
        }
        catch (Exception)
        {

            throw new ArgumentException("Only resource class can be generic local provider.");
        }

    }
    public string GetString(string name, CultureInfo? cultureInfo = default) => _resourceManager.GetString(name, cultureInfo ?? _cultureInfo)!;

    public string GetString(Expression<Func<string>> prop, CultureInfo? cultureInfo = default)
        => GetString(prop.GetPropetyName(), cultureInfo);
    public string GetString(Expression<Func<string>> prop, CultureInfo? cultureInfo = null, params string[] formatVars)
        => string.Format(GetString(prop, cultureInfo), formatVars);
    public string GetString(Expression<Func<string>> prop, params string[] formatVars)
        => string.Format(GetString(prop), formatVars);
}

