using Microsoft.Extensions.DependencyInjection;

namespace MaksimShimshon.BneiMikra.App.Shared.Services;
public static class LinkProtocolExt
{
    private static Dictionary<Type, Type> ProtocolLinks { get; set; } = new();
    public static Task ExecuteProtocolLinkCommand(this IServiceProvider serviceProvider, string key, Dictionary<string, string> parameters)
    {
        var handler = ProtocolLinks.SingleOrDefault(p => p.Key.Name.Equals(key, StringComparison.CurrentCultureIgnoreCase));
        if (handler.Key == default) return Task.CompletedTask;

        var typeService = handler.Value.GetInterfaces().Single(p => p.IsGenericType && p.GetGenericTypeDefinition() == typeof(ILinkProtocolHandler<>).GetGenericTypeDefinition());
        var handlerService = serviceProvider.GetRequiredService(typeService);
        var activator = Activator.CreateInstance(handler.Key) as LinkProtocolBaseRequest;
        activator!.Query = parameters;

        var genericArgument = typeService.GetGenericArguments()[0];
        var theGenericType = typeof(ILinkProtocolHandler<>).MakeGenericType(genericArgument);
        var prop = theGenericType.GetMethod("Handle");
        prop!.Invoke(handlerService, new object[] { activator, default });
        return Task.CompletedTask;
    }

    public static void RegisterProtocolLinks(this IServiceCollection serviceCollection)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(p => p.GetTypes()).ToList();
        foreach (var item in types)
        {
            var interfaces = item.GetInterfaces().ToList();
            var protocolHandlerInterface = interfaces.SingleOrDefault(p => p.IsGenericType && p.GetGenericTypeDefinition() == typeof(ILinkProtocolHandler<>).GetGenericTypeDefinition());
            var hasInterface = protocolHandlerInterface != default;
            if (hasInterface)
            {
                var typeArg = protocolHandlerInterface!.GenericTypeArguments[0];
                var command = types.Single(p => p == typeArg);
                ProtocolLinks.Add(command, item);
            }
        }

    }
}
