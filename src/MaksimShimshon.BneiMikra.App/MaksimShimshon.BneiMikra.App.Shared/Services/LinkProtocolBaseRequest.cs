namespace MiniChemist.Client.Web.UI.Abstractions.Providers.Event;
public abstract record LinkProtocolBaseRequest : ILinkProtocolRequest
{
    public IDictionary<string, string> Query { get; set; } = default!;
    public string Get(string key)
    {
        key = key.ToLower();
        return Query[key]!;
    }
    public TValue? GetAs<TValue>(string key)
    {
        object? obj = default;
        if (typeof(TValue) == typeof(Guid)) obj = Guid.Parse(Get(key));
        if (typeof(TValue) == typeof(ushort)) obj = ushort.Parse(Get(key));
        if (typeof(TValue) == typeof(uint)) obj = uint.Parse(Get(key));
        if (typeof(TValue) == typeof(double)) obj = double.Parse(Get(key));
        if (typeof(TValue) == typeof(float)) obj = float.Parse(Get(key));
        if (typeof(TValue) == typeof(decimal)) obj = decimal.Parse(Get(key));
        return obj != default ? (TValue)obj : default(TValue);
    }

}
