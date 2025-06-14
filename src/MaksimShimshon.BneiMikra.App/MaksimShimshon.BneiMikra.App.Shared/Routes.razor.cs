using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared;
public partial class Routes : ComponentBase
{
    [Inject] private IStartupProvider StartupProvider { get; set; } = null!;
    protected override async Task OnInitializedAsync()
    {
        await StartupProvider.Start();
    }
}