using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
public static class DependencyInjectorExt
{
    public static void InjectDependencies(this object target, IServiceProvider serviceProvider)
    {
        var properties = target.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(prop => prop.IsDefined(typeof(InjectAttribute), true));

        foreach (var prop in properties)
            if (prop.CanWrite)
            {
                var service = serviceProvider.GetService(prop.PropertyType);
                prop.SetValue(target, service);
            }
    }
}
