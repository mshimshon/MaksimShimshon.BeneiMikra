﻿using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.CoreMap;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.CoreMap.Engine;
internal class CoreMapper : ICoreMapper
{
    private readonly IServiceProvider _serviceProvider;

    public CoreMapper(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public TDestination MapTo<TOrigin, TDestination>(TOrigin origin) => origin.MapTo<TOrigin, TDestination>(_serviceProvider);
    public async Task<TDestination> MapToAsync<TOrigin, TDestination>(TOrigin origin)
        => await origin.MapToAsync<TOrigin, TDestination>(_serviceProvider);
}
