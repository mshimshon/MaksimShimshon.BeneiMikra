using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Layout;
public partial class MainLayout : LayoutComponentBase
{
    [Inject] private IDispatcher Dispatcher { get; set; } = default!;
    private MudThemeProvider MudThemeService { get; set; } = null!;
    private bool IsDarkMode { get; set; }
    private bool IsReady { get; set; } = false;
    protected override async Task OnInitializedAsync()
    {

        await base.OnInitializedAsync();
    }
    private MudTheme MyCustomTheme { get; set; } = new MudTheme()
    {
        PaletteLight = new PaletteLight()
        {
            Primary = Colors.Blue.Default,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.Red.Default,
        },
        PaletteDark = new PaletteDark()
        {
            Primary = Colors.Blue.Lighten1,
        },

        LayoutProperties = new LayoutProperties()
        {
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px"
        }
    };

    private bool IsLoadedApp { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {

            IsDarkMode = await MudThemeService.GetSystemDarkModeAsync();
            IsReady = true;
            StateHasChanged();
        }
    }
}
