using MaksimShimshon.BneiMikra.App.Shared.Contracts.Tanakh.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
public partial class TanakhReference : ComponentBase
{
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    [Inject] private IDialogService Dialog { get; set; } = default!;
    [Parameter] public TanakhReferenceResponse Data { get; set; } = default!;
    [Parameter] public bool UseShortName { get; set; } = false;
    private string BookName { get => AppResourceProvider.GetString($"TanakhBook{Data.Book}"); }
    private string BookNameShort { get => AppResourceProvider.GetString($"TanakhBook{Data.Book}Short"); }

    private string BookRefName { get => $"{BookName} {Data.Chapiter}:{Data.Verse}"; }
    private string BookRefNameAbrev { get => $"{BookNameShort} {Data.Chapiter}:{Data.Verse}"; }

    private async Task OpenDialog()
    {
        var option = new DialogOptions()
        {
            CloseButton = true,
            Position = DialogPosition.Center
        };
        var parameters = new DialogParameters
        {
            { nameof(TanakhReferenceDialog.BookName), Data.Book },
            { nameof(TanakhReferenceDialog.Verse), Data.Verse },
            { nameof(TanakhReferenceDialog.Chapiter), Data.Chapiter },
            { nameof(TanakhReferenceDialog.Note), Data.Note }
        };
        await Dialog.ShowAsync<TanakhReferenceDialog>(BookRefName, parameters, option);

    }
}
