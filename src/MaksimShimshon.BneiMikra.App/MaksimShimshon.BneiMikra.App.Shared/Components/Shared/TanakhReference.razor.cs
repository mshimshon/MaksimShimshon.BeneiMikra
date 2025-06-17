using Fluxor.Blazor.Web.Components;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class TanakhReference : FluxorComponent
{
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    [Inject] private IDialogService Dialog { get; set; } = default!;
    [Parameter] public TanakhReferenceResponse Data { get; set; } = default!;
    private string BookName { get => AppResourceProvider.GetString($"TanakhBook{Data.Book}"); }
    private string BookNameShort { get => AppResourceProvider.GetString($"TanakhBook{Data.Book}Short"); }

    private string BookRefName { get => $"{BookName} {Data.Chapiter}:{Data.Verse}"; }
    private string BookRefNameAbrev { get => $"{BookNameShort} {Data.Chapiter}:{Data.Verse}"; }

    [Parameter] public bool Expanded { get; set; } = false;
    private void OnExpandCollapseClick() => Expanded = !Expanded;
    private async Task OpenDialog()
    {
        var option = new DialogOptions()
        {
            CloseButton = true,
            Position = DialogPosition.Center
        };
        var parameters = new DialogParameters();
        parameters.Add(nameof(TanakhReferenceDialog.BookName), Data.Book);
        parameters.Add(nameof(TanakhReferenceDialog.Verse), Data.Verse);
        parameters.Add(nameof(TanakhReferenceDialog.Chapiter), Data.Chapiter);
        await Dialog.ShowAsync<TanakhReferenceDialog>(BookRefName, parameters, option);

    }
}
