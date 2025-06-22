using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
public interface IStrapiBlockProvider
{
    public RenderFragment RenderBlock(BlockResponse block);
    public bool CanRender(BlockResponse block);

}
