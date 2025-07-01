using MaksimShimshon.BneiMikra.App.Shared.Presentation.Services.Implementation;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared;
public partial class Routes : ComponentBase
{
    [Inject] IJSRuntime JavascriptRuntime { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        JavascriptProvider.JSRuntime = JavascriptRuntime;
    }
}