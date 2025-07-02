global using MediatR;
global using MudBlazor;
global using MudBlazor.Services;
global using StatePulse.Net;
global using SwizzleV;
using MaksimShimshon.BneiMikra.App.Shared.Presentation;
using Microsoft.Extensions.DependencyInjection;
namespace MaksimShimshon.BneiMikra.App.Shared;
public static class ServiceRegisterExt
{
    public static void AddUIServices(this IServiceCollection services)
    {

        services.AddPresentationServices();


    }

}
