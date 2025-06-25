using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Internal;
internal static class StrapiEnumMappings
{
    internal static readonly IReadOnlyDictionary<StrapiFilterOperator, string> _operatorMap = new Dictionary<StrapiFilterOperator, string>
    {
        [StrapiFilterOperator.Equal] = "$eq",
        [StrapiFilterOperator.NotEqual] = "$ne",
        [StrapiFilterOperator.LessThan] = "$lt",
        [StrapiFilterOperator.LessThanOrEqual] = "$lte",
        [StrapiFilterOperator.GreaterThan] = "$gt",
        [StrapiFilterOperator.GreaterThanOrEqual] = "$gte",
        [StrapiFilterOperator.In] = "$in",
        [StrapiFilterOperator.NotIn] = "$notIn",
        [StrapiFilterOperator.Contains] = "$contains",
        [StrapiFilterOperator.ContainsInsensitive] = "$containss",
        [StrapiFilterOperator.IsNull] = "$null",
        [StrapiFilterOperator.IsNotNull] = "$notNull",
        [StrapiFilterOperator.Between] = "$between",
        [StrapiFilterOperator.StartsWith] = "$startsWith",
        [StrapiFilterOperator.EndsWith] = "$endsWith",
        [StrapiFilterOperator.And] = "$and",
        [StrapiFilterOperator.Or] = "$or",
        [StrapiFilterOperator.Not] = "$not"
    };

    internal static readonly IReadOnlyDictionary<StrapiShortDirection, string> _sortDirection = new Dictionary<StrapiShortDirection, string>
    {
        [StrapiShortDirection.Descesding] = "desc",
        [StrapiShortDirection.Ascending] = "asc",
    };

}

