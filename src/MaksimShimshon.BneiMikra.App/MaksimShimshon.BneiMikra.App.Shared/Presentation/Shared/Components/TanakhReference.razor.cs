using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Components.Shared;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.ViewModels;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Resources;
using Microsoft.AspNetCore.Components;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components;
public partial class TanakhReference : ComponentBase
{
    [Inject] private IResourceProvider<ApplicationResource> AppResourceProvider { get; set; } = default!;
    [Inject] private IDialogService Dialog { get; set; } = default!;
    [Parameter] public TanakhReferenceEntity Data { get; set; } = default!;
    [Parameter] public bool UseShortName { get; set; } = false;

    private TanakhReferenceViewModel ViewModel { get; set; } = default!;
    protected override async Task OnInitializedAsync()
    {
        var vmHook =
            SwizzleFact.CreateOrGet<TanakhReferenceViewModel>(() => this, () => InvokeAsync(() => StateHasChanged()));

        ViewModel = vmHook.GetViewModel<TanakhReferenceViewModel>()!;
        ViewModel.TanakhRef = Data;
        await ViewModel.Initialize();
    }

    private async Task OpenDialog()
    {
        var option = new DialogOptions()
        {
            CloseButton = true,
            Position = DialogPosition.Center
        };
        var parameters = new DialogParameters
        {
            { nameof(TanakhReferenceDialog.BookName), ViewModel.TanakhRef.Reference.Book },
            { nameof(TanakhReferenceDialog.Verse), ViewModel.TanakhRef.Reference.Verse },
            { nameof(TanakhReferenceDialog.Chapiter), ViewModel.TanakhRef.Reference.Chapiter },
            { nameof(TanakhReferenceDialog.Note), ViewModel.TanakhRef.Note }
        };
        await Dialog.ShowAsync<TanakhReferenceDialog>(ViewModel.RefereneceName, parameters, option);

    }
}
