using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class DynamicBlock<TEntity>
    where TEntity : class
{
    public TEntity Instance { get; set; } = default!;
    [Parameter] public string WhenComponent { get; set; } = default!;
    [Parameter] public BlockResponse BlockResp { get; set; } = default!;
    [Parameter] public RenderFragment<TEntity> ChildContent { get; set; } = default!;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        Instance = JsonSerializer.Deserialize<TEntity>(BlockResp.RawContent, GlobalJsonOptions.UseGlobal())!;
    }
}
