using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
public interface IStrapiBlockProvider
{
    public RenderFragment RenderBlock(BlockResponse block);
    public bool CanRender(BlockResponse block);

}
